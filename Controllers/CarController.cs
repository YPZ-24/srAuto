using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SrAuto.Data;
using SrAuto.Models;

namespace SrAuto.Controllers
{
    public class CarController : Controller
    {
        private readonly SrAutoContext _context;

        public CarController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("carTag, brand, model, photoUrl, ClientID")] Car car){
            try{
                 //Validamos si la matricula ya esta en uso
                Car isCarTaken = _context.Cars.AsNoTracking().Where(c => c.carTag == car.carTag).FirstOrDefault<Car>();
                if(isCarTaken != null){
                    throw new Exception("El auto ya esta en el sitio");
                }
                //Si paso las validaciones, creamos
                _context.Database.ExecuteSqlRaw("CreateCar "+car.ClientID+", '"+car.brand+"', '"+car.model+"', '"+car.carTag+"', '"+car.photoUrl+"'");
                await _context.SaveChangesAsync();
                
                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Creado";
                
                return RedirectToAction(car.ClientID.ToString(), "Client");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Clients", "Client");
            }
        }

        [HttpPost]
        [Route("Car/Update")]
        public async Task<ActionResult> Update([Bind("carTag, brand, model, photoUrl, ClientID, CarID")] Car car){
            try{
                //Validamos si la matricula ya esta en uso
                Car isCarTaken = _context.Cars.AsNoTracking().Where(c => c.carTag == car.carTag).FirstOrDefault<Car>();
                //Si la matricula existe y no es la que esta siendo editada
                if(isCarTaken != null){
                    if(isCarTaken.CarID != car.CarID){
                        throw new Exception("La matricula ya esta en uso");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Cars.Update(car);
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Actualizado";
                
                return RedirectToAction(car.CarID.ToString(), "Car");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction(car.CarID.ToString(), "Car");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("CarID")] Car car){
            try{
                Car existingCar = _context.Cars.AsNoTracking().Where(c => c.CarID == car.CarID).FirstOrDefault<Car>();
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(existingCar.ClientID.ToString(), "Client");
            }catch(Exception e){
                Console.Write(e);
                return RedirectToAction(car.CarID.ToString(), "Car");
            }
        }

        [HttpGet]
        [Route("Car/{CarID}")]
        public IActionResult Index(int CarID)
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }

            ViewData["CarID"] = CarID;

            List<Date> dt = _context.Dates.FromSqlRaw<Date>("GetCarDates "+CarID).ToList();
            for(int i=0; i<dt.Count; i++){
                dt[i].DateFixes = _context.DateFixes.AsNoTracking().Where(cf => cf.DateID == dt[i].DateID).ToList<DateFix>();
                for(int j=0; j<dt[i].DateFixes.Count; j++){
                    dt[i].DateFixes[j].Fix = _context.Fixes.AsNoTracking().Where(f => f.FixID == dt[i].DateFixes[j].FixID).FirstOrDefault<Fix>();
                }
            }

            ViewData["carDates"] = dt;
            ViewData["fixes"] = _context.Fixes.ToList<Fix>();

            var cars = _context.Cars.AsNoTracking().Where(c => c.CarID == CarID).FirstOrDefault<Car>();
            return View(cars);
        }

    }
}

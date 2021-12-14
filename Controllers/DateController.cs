using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SrAuto.Data;
using SrAuto.Models;

namespace SrAuto.Controllers
{
    public class DateController : Controller
    {

        private readonly SrAutoContext _context;

        public DateController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Pay([Bind("DateID")] Date date){
            try{
                //actualizamos (pagamos)
                _context.Database.ExecuteSqlRaw("PayDate "+date.DateID);
                await _context.SaveChangesAsync();
                TempData["kindInfoModal"] = "update";
                TempData["msjInfoModal"] = "Pagado";
                return RedirectToAction("Dates", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Dates", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("carTag, DateReasonID, name, datet, description")] Date date){
            try{
                Car carTagExistis = _context.Cars.AsNoTracking().Where(d => d.carTag == date.carTag).FirstOrDefault<Car>(); 
                if(carTagExistis == null)  throw new Exception("La matricula no existe");
                //Creamos
                _context.Database.ExecuteSqlRaw("CreateDate "+carTagExistis.CarID+", "+date.DateReasonID+", '"+date.name+"', '"+date.datet.ToString("yyyy-MM-dd HH:mm:ss")+"', '"+date.description+"'");
                await _context.SaveChangesAsync();
                
                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Creado";

                return RedirectToAction("Dates", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Dates", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("DateID")] Date date){
            try{
                _context.Dates.Remove(date);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dates", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";

                var sqlException = e.GetBaseException() as SqlException;
                if(sqlException.Number == 547){
                    TempData["msjInfoModal"] = "No puedes eliminar esta cita, tiene relación con otros datos";
                }else{
                    TempData["msjInfoModal"] = e.Message;
                }
                return RedirectToAction("Dates", "Config");
            }
        }

    }
}

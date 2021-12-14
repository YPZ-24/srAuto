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
    public class ClientController : Controller
    {

        private readonly SrAutoContext _context;

        public ClientController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Client/{ClientID}")]
        public IActionResult Index(int ClientID)
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }

            ViewData["subjects"] = _context.Subjects.ToList();
            ViewData["clientCars"] = _context.Cars.FromSqlRaw<Car>("GetClientCars "+ClientID).ToList();
            ViewData["ClientID"] = ClientID;
            var client = _context.Clients.AsNoTracking().Where(c => c.ClientID == ClientID).FirstOrDefault<Client>();
            return View(client);
        }

        [HttpPost]
        public async Task<ActionResult> Update([Bind("email, cellphone, address, ClientID")] Client client){
            try{
                //Validamos si el correo ya existe
                Client isClientTaken = _context.Clients.AsNoTracking().Where(c => c.email == client.email).FirstOrDefault<Client>();
                //Si el email existe y no es la que esta siendo editada
                if(isClientTaken != null){
                    if(isClientTaken.ClientID != client.ClientID){
                        throw new Exception("El correo ya esta en uso");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Clients.Update(client);
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "updated";
                TempData["msjInfoModal"] = "Actualizado";

                return RedirectToAction("Clients", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Clients", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("email, cellphone, address")] Client client){
            try{
                Client isClientTaken = _context.Clients.AsNoTracking().Where(c => c.email == client.email).FirstOrDefault<Client>();
                if(isClientTaken != null){
                    throw new Exception("El correo ya esta en uso");
                }
                //Si paso las validaciones, creamos
                _context.Database.ExecuteSqlRaw("CreateClient '"+client.email+"', '"+client.cellphone+"', '"+client.address+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "update";
                TempData["msjInfoModal"] = "Creado";
                
                return RedirectToAction("Clients", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Clients", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("ClientID")] Client client){
            try{
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
                return RedirectToAction("Clients", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";

                var sqlException = e.GetBaseException() as SqlException;
                if(sqlException.Number == 547){
                    TempData["msjInfoModal"] = "No puedes eliminar este cliente, tiene relación con otros datos";
                }else{
                    TempData["msjInfoModal"] = e.Message;
                }
                return RedirectToAction("Clients", "Config");
            }
        }

    }
}

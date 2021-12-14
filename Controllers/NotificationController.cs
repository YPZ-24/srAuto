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
    public class NotificationController : Controller
    {

        private readonly SrAutoContext _context;

        public NotificationController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("SubjectID, description, ClientID")] Notification notification){
            try{
                //Creamos
                _context.Database.ExecuteSqlRaw("CreateNotification "+notification.SubjectID+","+notification.ClientID+",'"+notification.description+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Creado";
                
                return RedirectToAction(notification.ClientID.ToString(), "Client");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction(notification.ClientID.ToString(), "Client");
            }
        }

    }
}

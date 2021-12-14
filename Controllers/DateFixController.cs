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
    public class DateFixController : Controller
    {

        private readonly SrAutoContext _context;

        public DateFixController(SrAutoContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public async Task<ActionResult> Create([Bind("FixID, DateID, extraCost")] DateFix dateFix){
            try{
                DateFix isDateFixTaken = _context.DateFixes.AsNoTracking().Where(df => df.FixID == dateFix.FixID && df.DateID == dateFix.DateID).FirstOrDefault<DateFix>();                

                if(isDateFixTaken != null){
                    //Si ya existe, actualizamos    
                    _context.Database.ExecuteSqlRaw("UpdateDateFix '"+dateFix.FixID+"', '"+dateFix.DateID+"', '"+(isDateFixTaken.extraCost + dateFix.extraCost)+"'");
                }else{
                    //Si aun no existe, creamos
                    _context.Database.ExecuteSqlRaw("CreateDateFix '"+dateFix.FixID+"', '"+dateFix.DateID+"', '"+dateFix.extraCost+"'");
                }
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
        public async Task<ActionResult> Delete([Bind("DateFixID")] DateFix dateFix){
            try{
                _context.DateFixes.Remove(dateFix);
                await _context.SaveChangesAsync();
                TempData["kindInfoModal"] = "delete";
                TempData["msjInfoModal"] = "Eliminado";
                return RedirectToAction("Dates", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Dates", "Config");
            }
        }

    }
}

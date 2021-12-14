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
    public class DateReasonController : Controller
    {

        private readonly SrAutoContext _context;

        public DateReasonController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("reason")] DateReason dateReason){
            try{
                //Validamos si la razón ya existe
                DateReason isReasonTaken = _context.DateReasons.AsNoTracking().Where(dt => dt.reason == dateReason.reason).FirstOrDefault<DateReason>();
                if(isReasonTaken != null){
                    throw new Exception("Esta razón ya existe");
                }
                //Creamos
                _context.Database.ExecuteSqlRaw("CreateDateReason '"+dateReason.reason+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Creado";
                
                return RedirectToAction("DateReasons", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("DateReasons", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("DateReasonID")] DateReason dateReason){
            try{
                _context.DateReasons.Remove(dateReason);
                await _context.SaveChangesAsync();
                return RedirectToAction("DateReasons", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";

                var sqlException = e.GetBaseException() as SqlException;
                if(sqlException.Number == 547){
                    TempData["msjInfoModal"] = "No puedes eliminar esta razón de cita, tiene relación con otros datos";
                }else{
                    TempData["msjInfoModal"] = e.Message;
                }
                return RedirectToAction("DateReasons", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Update([Bind("DateReasonID, reason")] DateReason dateReason){
            try{
                //Validamos si la reazón ya existe
                DateReason isReasonTaken = _context.DateReasons.AsNoTracking().Where(dr => dr.reason == dateReason.reason).FirstOrDefault<DateReason>();
                //Si el ajuste existe y no es el que esta siendo editada
                if(isReasonTaken != null){
                    if(isReasonTaken.DateReasonID != dateReason.DateReasonID){
                        throw new Exception("La razón ya existe");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Database.ExecuteSqlRaw("UpdateDateReason "+dateReason.DateReasonID+", '"+dateReason.reason+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "updated";
                TempData["msjInfoModal"] = "Actualizado";
                
                return RedirectToAction("DateReasons", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("DateReasons", "Config");
            }
        }

    }
}

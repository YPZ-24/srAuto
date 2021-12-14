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
    public class FixController : Controller
    {
        private readonly SrAutoContext _context;

        public FixController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("fix, price")] Fix newFix){
            try{
                 //Validamos si el arreglo ya existe
                Fix isFixTaken = _context.Fixes.AsNoTracking().Where(f => f.fix == newFix.fix).FirstOrDefault<Fix>();
                if(isFixTaken != null){
                    throw new Exception("Este arreglo ya esta en el sitio");
                }
                //Si paso las validaciones, creamos
                _context.Database.ExecuteSqlRaw("CreateFix '"+newFix.fix+"', "+newFix.price+"");
                await _context.SaveChangesAsync();
                
                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Creado";
                
                return RedirectToAction("Fixes", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Fixes", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Update([Bind("FixID, fix, price")] Fix newFix){
            try{
                //Validamos si la el ajuste ya existe
                Fix isFixTaken = _context.Fixes.AsNoTracking().Where(f => f.fix == newFix.fix).FirstOrDefault<Fix>();
                //Si el ajuste existe y no es el que esta siendo editada
                if(isFixTaken != null){
                    if(isFixTaken.FixID != newFix.FixID){
                        throw new Exception("El ajuste ya existe");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Fixes.Update(newFix);
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "updated";
                TempData["msjInfoModal"] = "Actualizado";
                
                return RedirectToAction("Fixes", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Fixes", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("FixID")] Fix fix){
            try{
                _context.Fixes.Remove(fix);
                await _context.SaveChangesAsync();
                return RedirectToAction("Fixes", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";

                var sqlException = e.GetBaseException() as SqlException;
                if(sqlException.Number == 547){
                    TempData["msjInfoModal"] = "No puedes eliminar este arreglo, tiene relación con otros datos";
                }else{
                    TempData["msjInfoModal"] = e.Message;
                }
                return RedirectToAction("Fixes", "Config");
            }
        }

    }
}

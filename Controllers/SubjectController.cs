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
    public class SubjectController : Controller
    {

        private readonly SrAutoContext _context;

        public SubjectController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("subject")] Subject newSubject){
            try{
                //Validamos si la materia ya existe
                Subject isSubjectTaken = _context.Subjects.AsNoTracking().Where(s => s.subject == newSubject.subject).FirstOrDefault<Subject>();
                if(isSubjectTaken != null){
                    throw new Exception("Este asunto ya existe");
                }
                //Creamos
                _context.Database.ExecuteSqlRaw("CreateSubject '"+newSubject.subject+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Enviado";
                
                return RedirectToAction("Subjects", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Subjects", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("SubjectID")] Subject subject){
            try{
                _context.Subjects.Remove(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction("Subjects", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";

                var sqlException = e.GetBaseException() as SqlException;
                if(sqlException.Number == 547){
                    TempData["msjInfoModal"] = "No puedes eliminar este asunto, tiene relación con otros datos";
                }else{
                    TempData["msjInfoModal"] = e.Message;
                }
                return RedirectToAction("Subjects", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Update([Bind("SubjectID, subject")] Subject newSubject){
            try{
                //Validamos si la el asunto ya existe
                Subject isSubjectTaken = _context.Subjects.AsNoTracking().Where(s => s.subject == newSubject.subject).FirstOrDefault<Subject>();
                //Si el ajuste existe y no es el que esta siendo editada
                if(isSubjectTaken != null){
                    if(isSubjectTaken.SubjectID != newSubject.SubjectID){
                        throw new Exception("El asunto ya existe");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Subjects.Update(newSubject);
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "update";
                TempData["msjInfoModal"] = "Actualizado";
                
                return RedirectToAction("Subjects", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Subjects", "Config");
            }
        }

    }
}

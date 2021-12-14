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
    public class UserController : Controller
    {

        private readonly SrAutoContext _context;

        public UserController(SrAutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("email, pass")] User user, string confPass){
            try{
                if(confPass != user.pass) throw new Exception("Las contraseñas no coinciden");

                //Validamos si el correo ya esta en uso
                User isEmailTaken = _context.Users.AsNoTracking().Where(u => u.email == user.email).FirstOrDefault<User>();
                if(isEmailTaken != null){
                    throw new Exception("Este email ya esta en uso");
                }
                //Creamos
                _context.Database.ExecuteSqlRaw("CreateUser '"+user.email+"', '"+user.pass+"'");
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "create";
                TempData["msjInfoModal"] = "Enviado";
                
                return RedirectToAction("Users", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Users", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete([Bind("UserID")] User user){
            try{
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Users", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Users", "Config");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Update([Bind("UserID, email, pass")] User user){
            try{
                //Validamos si el email ya esta en uso
                User isEmailTaken = _context.Users.AsNoTracking().Where(u => u.email == user.email).FirstOrDefault<User>();
                //Si el ajuste existe y no es el que esta siendo editada
                if(isEmailTaken != null){
                    if(isEmailTaken.UserID != user.UserID){
                        throw new Exception("El correo ya esta en uso");
                    }
                }

                //Si paso las validaciones, actualizamos
                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                TempData["kindInfoModal"] = "update";
                TempData["msjInfoModal"] = "Actualizado";
                
                return RedirectToAction("Users", "Config");
            }catch(Exception e){
                Console.Write(e);
                TempData["kindInfoModal"] = "error";
                TempData["msjInfoModal"] = e.Message;
                return RedirectToAction("Users", "Config");
            }
        }

    }
}

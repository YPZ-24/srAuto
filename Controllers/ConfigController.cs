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
    public class ConfigController : Controller
    {

        private readonly SrAutoContext _context;

        public ConfigController(SrAutoContext context)
        {
            _context = context;
        }

        public IActionResult Users()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }
            
            List<User> users = _context.Users.ToList<User>();
            return View(users);
        }

        public IActionResult Subjects()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }
            
            List<Subject> subjects = _context.Subjects.ToList<Subject>();
            return View(subjects);
        }

        public IActionResult DateReasons()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }
            
            List<DateReason> dateReasons = _context.DateReasons.ToList<DateReason>();
            return View(dateReasons);
        }

        public IActionResult Fixes()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }

            List<Fix> fixes = _context.Fixes.ToList<Fix>();
            return View(fixes);
        }

        public IActionResult Clients()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }
            var clients =  _context.Clients.ToList<Client>();
            return View(clients);
        }

        public IActionResult Dates()
        {
            ViewData["kindInfoModal"] = TempData["kindInfoModal"];
            if(ViewData["kindInfoModal"] != null) {
                ViewData["showInfoModal"] = "show";
                ViewData["msjInfoModal"] = TempData["msjInfoModal"];
            }

            var dates =  _context.Dates.FromSqlRaw<Date>("GetDatesIncludingCarTag").ToList();
            for(int i=0; i<dates.Count; i++){
                dates[i].DateFixes = _context.DateFixes.AsNoTracking().Where(cf => cf.DateID == dates[i].DateID).ToList<DateFix>();
                for(int j=0; j<dates[i].DateFixes.Count; j++){
                    dates[i].DateFixes[j].Fix = _context.Fixes.AsNoTracking().Where(f => f.FixID == dates[i].DateFixes[j].FixID).FirstOrDefault<Fix>();
                }
            }
            ViewData["fixes"] = _context.Fixes.ToList<Fix>();
            ViewData["dateReasons"] = _context.DateReasons.ToList();
            return View(dates);
        }


    }
}

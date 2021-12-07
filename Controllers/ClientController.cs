using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SrAuto.Models;

namespace SrAuto.Controllers
{
    public class ClientController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}

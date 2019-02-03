using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wayuu.Services;

namespace Wayuu.WebApp.Controllers
{
    public class LogsController : Controller
    {
        private IWayuuLogOperations Helper;

        public LogsController(IWayuuLogOperations wayuuLogOperations)
        {
            this.Helper = wayuuLogOperations;
        }

        public IActionResult GetALL()
        {
            var Model = Helper.GetAll();
            return View(Model);
        }
    }
}
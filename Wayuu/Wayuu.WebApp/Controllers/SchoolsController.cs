using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.WebApp.Controllers
{
    public class SchoolsController : Controller
    {
        ISchoolOperations Helper;

        public SchoolsController(ISchoolOperations schoolOperations)
        {
            this.Helper = schoolOperations;
        }

        public IActionResult Index()
        {
            var Schools = Helper.GetAll();
            return View(Schools);
        }

        [HttpPost]
        public IActionResult Index(string schoolName)
        {
            School School = new School
            {
                Name = schoolName
            };
            School = Helper.Create(School);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var SchoolFound = Helper.RetrieveById(id);
               // RetrieveSchoolById(id);
            return View(SchoolFound);
        }

        [HttpPost]
        public IActionResult UpdateOrDelete(School school, string BtnUpdate, string BtnDelete)
        {

            if (BtnUpdate != null)
            {
                Helper.Update(school);
            }
            else if (BtnDelete != null)
            {
                Helper.DeleteWithLog(school.Id);
            }
            return RedirectToAction("Index");
        }
    }
}
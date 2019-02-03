using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Create(string name)
        {
            IActionResult Result;
            School School = new School
            {
                Name = name
            };
            School = Helper.Create(School);
            if (School != null)
            {
                Result = Content($"Insertada! {School.Id}");
            }
            else
            {
                Result = Content($"No se Inserto!");
            }
            return Result;
        }

        public IActionResult Retrieve(int id)
        {
            IActionResult Result;
            var School = Helper.RetrieveSchoolById(id);
            if (School != null)
            {
                Result = Content($"Se encontro la Escuela: {School.Id} , {School.Name}");
            }
            else
            {
                Result = Content($"No se Econtro Escuela!");
            }
            return Result;
        }

        public IActionResult Update(int id, string name, string address, int telephone, string email)
        {
            IActionResult Result;
            var School = new School
            {
                Name = name,
                Address = address,
                Telephone = telephone,
                Email = email
            };
            var UpdateResult = Helper.Update(School);
            if (UpdateResult)
            {
                Result = Content("Categoria Modificada");
            }
            else
            {
                Result = Content($"No se pudo modificar Econtro Escuela!");
            }
            return Result;

        }

        public IActionResult Delete(int id, bool withLog = false)
        {
            IActionResult Result;
            var DeleteResult = withLog ? Helper.DeleteWithLog(id)
                : Helper.Delete(id);
            if (DeleteResult)
            {
                Result = Content("Categoria Eliminada");
            }
            else
            {
                Result = Content($"No se pudo eliminar la Escuela!");
            }
            return Result;
        }

        public IActionResult ALL()
        {
            var Model = Helper.GetAll();
            return View(Model);
        }
    }
}
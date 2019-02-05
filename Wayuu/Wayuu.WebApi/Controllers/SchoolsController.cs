using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        ISchoolOperations Helper;

        public SchoolsController(ISchoolOperations schoolOperations)
        {
            this.Helper = schoolOperations;
        }

        [HttpGet]
        public IEnumerable<School> Get()
        {
            return Helper.GetAll();
        }

        [HttpGet("{id}", Name = "CreatedSchool")]
        public IActionResult GetById(int id)
        {
            var SchoolFound = Helper.RetrieveSchoolById(id);
            if (SchoolFound == null)
            {
                return NotFound();
            }
            return Ok(SchoolFound);
        }

        [HttpPost]
        public IActionResult Post([FromBody] School newSchool)
        {
            if (ModelState.IsValid)
            {
                var School = Helper.Create(newSchool);
                return new CreatedAtRouteResult("CreatedSchool", new { id = School.Id }, School);
            }
            return BadRequest(ModelState);
        }
    }
}
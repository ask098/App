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
    public class TeachersController : ControllerBase
    {
        ITeacherOperations Helper;

        public TeachersController(ITeacherOperations teacherOperations)
        {
            this.Helper = teacherOperations;
        }

        [HttpGet]
        public IEnumerable<Teacher> GetAll()
        {
            return Helper.GetAll();
        }

        [HttpGet("{id}", Name = "CreatedTeacher")]
        public IActionResult RetrieveById(int id)
        {
            var TeacherFound = Helper.RetrieveById(id);
            if (TeacherFound == null)
            {
                return NotFound();
            }
            return Ok(TeacherFound);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Teacher newTeacher)
        {
            if (ModelState.IsValid)
            {
                var Teacher = Helper.Create(newTeacher);
                return new CreatedAtRouteResult("CreatedSchool", new { id = Teacher.Id }, Teacher);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Teacher teacher, int id)
        {
            if (ModelState.IsValid && teacher.Id == id)
            {
                Helper.Update(teacher);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Teacher teacher, int id)
        {
            if (Helper.DeleteWithLog(teacher.Id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
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
    public class StudentsController : ControllerBase
    {
        IStudentOperations Helper;

        public StudentsController(IStudentOperations studentOperations)
        {
            this.Helper = studentOperations;
        }

        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return Helper.GetAll();
        }

        [HttpGet("{id}", Name = "CreatedStudent")]
        public IActionResult RetrieveStudentById(int id)
        {
            var StudentFound = Helper.RetrieveById(id);
            if (StudentFound == null)
            {
                return NotFound();
            }
            return Ok(StudentFound);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student newStudent)
        {
            if (ModelState.IsValid)
            {
                var Student = Helper.Create(newStudent);
                return new CreatedAtRouteResult("CreatedStudent", new { id = Student.Id }, Student);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Student student, int id)
        {
            if (ModelState.IsValid && student.Id == id)
            {
                Helper.Update(student);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Student student, int id)
        {
            if (Helper.DeleteWithLog(student.Id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
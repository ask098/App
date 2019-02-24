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
    public class CoursesController : ControllerBase
    {
        ICourseOperations Helper;

        public CoursesController(ICourseOperations courseOperations)
        {
            this.Helper = courseOperations;
        }

        [HttpGet]
        public IEnumerable<Course> GetAll()
        {
            return Helper.GetAll();
        }

        [HttpGet("{id}", Name = "CreatedCourse")]
        public IActionResult RetriveCourseById (int id)
        {
            var CourseFound = Helper.RetrieveById(id);
            if (CourseFound == null)
            {
                return NotFound();
            }
        return Ok(CourseFound);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Course newCourse)
        {
            if (ModelState.IsValid)
            {
                var Course = Helper.Create(newCourse);
                return new CreatedAtRouteResult("CreatedCourse", new { id = Course.Id }, Course);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Course course, int id)
        {
            if (ModelState.IsValid && course.Id == id)
            {
                Helper.Update(course);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Course course, int id)
        {
            if (Helper.DeleteWithLog(course.Id))
            {
                return Ok();
            }
            return NotFound();
        }

    }
}

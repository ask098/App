﻿using System;
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
        public IEnumerable<School> GetAll()
        {
            return Helper.GetAll();
        }

        [HttpGet("{id}", Name = "CreatedSchool")]
        public IActionResult RetrieveById(int id)
        {
            var SchoolFound = Helper.RetrieveById(id);
            if (SchoolFound == null)
            {
                return NotFound();
            }
            return Ok(SchoolFound);
        }

        [HttpPost]
        public IActionResult Create([FromBody] School newSchool)
        {
            if (ModelState.IsValid)
            {
                var School = Helper.Create(newSchool);
                return new CreatedAtRouteResult("CreatedSchool", new { id = School.Id }, School);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] School school, int id)
        {
            if (ModelState.IsValid && school.Id == id)
            {
                Helper.Update(school);
                return Ok();                
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] School school, int id)
        {
            if (Helper.DeleteWithLog(school.Id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
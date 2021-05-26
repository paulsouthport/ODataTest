using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataTest.Models;
using System;
using System.Collections.Generic;

namespace ODataTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(new List<Student>
            { 
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Paul Ruddock",
                    Grade = 1
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Tim Stone",
                    Grade = 2
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Stephen Blair",
                    Grade = 3
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Chris James",
                    Grade = 1
                },
                 new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Steven Kearns",
                    Grade = 99
                }
            });
        }
    }
}

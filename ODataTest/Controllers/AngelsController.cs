using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataTest.Models;
using System;
using System.Collections.Generic;

namespace ODataTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngelsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public ActionResult<List<Angel>> GetAllStudents()
        {
            return Ok(new List<Angel>
            { 
                new Angel
                {
                    Id = Guid.NewGuid(),
                    Name = "Paul Ruddock",
                    Grade = 1
                },
                new Angel
                {
                    Id = Guid.NewGuid(),
                    Name = "Tim Stone",
                    Grade = 2
                },
                new Angel
                {
                    Id = Guid.NewGuid(),
                    Name = "Stephen Blair",
                    Grade = 3
                },
                new Angel
                {
                    Id = Guid.NewGuid(),
                    Name = "Chris James",
                    Grade = 1
                },
                 new Angel
                {
                    Id = Guid.NewGuid(),
                    Name = "Steven Kearns",
                    Grade = 99
                }
            });
        }
    }
}

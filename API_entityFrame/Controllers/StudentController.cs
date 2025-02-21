using API_entityFrame.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using API_entityFrame.Data; // Chứa StudentContext

namespace ett1_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        //action
        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(Students student)
        {

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Student added successfully", student });

        }

    }
}
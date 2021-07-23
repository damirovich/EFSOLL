using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _004TaskAllWebApi.Models;
using _004TaskAllWebApi.Repository;

namespace _004TaskAllWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IRepository<Student> contextStudent { get; private set; }
        public StudentsController(IRepository<Student> contextStudent)
        {
            this.contextStudent = contextStudent;
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var student= await Task.Run(() => contextStudent.FindById(id));
            if (student == null) {
                return NotFound();
            }
            return student;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            List<Student> res = null;
            try
            {
                await Task.Run(()=> res = contextStudent.All().ToList());
                if (res.Count == 0)
                {
                    return NotFound();
                }
            }
            catch {
                return BadRequest();
            }
            return Ok(res);
        }
        // PUT: api/Students/5
        [HttpPut]
        public async void Put([FromBody] Student student)
        {
             await Task.Run(() => contextStudent.Update(student));
        }
        [HttpPost]
        public async void Post([FromBody] Student student)
        {
            await Task.Run(()=> contextStudent.Add(student));
        }
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var stdudent = await Task.Run(()=> contextStudent.FindById(id));
            contextStudent.Delete(stdudent);
        }
    }
}

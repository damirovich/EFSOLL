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
    public class GroupsController : ControllerBase
    {
        public IRepository<Group> contextGroup { get; private set; }
        public GroupsController(IRepository<Group> contextGroup)
        {
            this.contextGroup = contextGroup;
        }
        [HttpGet]
        public async Task<ActionResult<Group>> Get()
        {
            List<Group> groups = null;
            try {
                await Task.Run(() => groups= contextGroup.All().ToList());
                if (groups == null) {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
            return Ok(groups);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> Get(int id)
        {
            var group = await Task.Run(() => contextGroup.FindById(id));
            if (group == null) {
                return NotFound();
            }
            return group;
        }

        [HttpPut]
        public async void Put([FromQuery] Group group)
        {
            await Task.Run(()=> contextGroup.Add(group));
        }
        [HttpPost]
        public async void Post( [FromBody] Group group)
        {
            await Task.Run(() => contextGroup.Add(group));
           
        }
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var group = await Task.Run(()=> contextGroup.FindById(id));
            contextGroup.Delete(group);
        }
    }
}

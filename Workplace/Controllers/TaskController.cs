﻿using Microsoft.AspNetCore.Mvc;
using Workplace.Data;
using Workplace.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController(IDataService data) : ControllerBase
    {
        // GET: api/<TaskController>
        [HttpGet]
        public async Task<IEnumerable<TaskItemDTO>> GetAsync()
        {
            return await data.GetAllAsync();
        }

        //// GET api/<TaskController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<TaskController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<TaskController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TaskController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

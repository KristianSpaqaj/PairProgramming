using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PairProgramming.Managers;
using PairProgramming.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PairProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static RecordManager _manager = new RecordManager(new List<Record>()
        {

        });


        // GET: api/<RecordsController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public Record Get(int id)
        {
            return _manager.GetById();
        }

        // POST api/<RecordsController>
        [HttpPost]
        public Record Post([FromBody] Record value)
        {
            return _manager.Add(value);
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public Record Put(int id, [FromBody] Record value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}

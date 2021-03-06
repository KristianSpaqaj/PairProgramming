using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            new Record(1,"Silver star", "Frank Valli & The Four Seasons", 362, 1975),
            new Record(2,"Heartless", "The Weeknd", 201, 2019),
            new Record(3,"Flashing Lights", "Kanye West", 237, 2007),
        });


        // GET: api/<RecordsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Record>> Get([FromQuery]string title, string artist, int? duration, int? date)
        {
            return Ok(_manager.GetAll(title, artist, duration, date));
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Record> Get(int id)
        {
            Record result =  _manager.GetById(id);
            if (result == null)
            {
                return NotFound("id not found " + id);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<RecordsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Record> Post([FromBody] Record value)
        {
            try
            {
                Record record = _manager.Add(value);
                string uri = Url.RouteUrl(RouteData.Values) + "/" + record.Id;
                return Created(uri, record);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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

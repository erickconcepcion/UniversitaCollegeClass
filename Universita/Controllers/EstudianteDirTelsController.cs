using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Universita.Services;

namespace Universita.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteDirTelsController : ControllerBase
    {
        private readonly IQueryService _service;
        public EstudianteDirTelsController(IQueryService service)
        {
            _service = service;
        }
        // GET: api/EstudianteDirTels
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EstudianteDirTels/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EstudianteDirTels
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/EstudianteDirTels/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

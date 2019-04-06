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
    public class MedioPagosController : ControllerBase
    {
        private readonly IQueryService _service;
        public MedioPagosController(IQueryService service)
        {
            _service = service;
        }
        // GET: api/MedioPagos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MedioPagos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MedioPagos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MedioPagos/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servuniv.Data.Entities;
using Universita.Services;

namespace Universita.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteActividadesController : ControllerBase
    {
        private readonly IQueryService _service;
        public EstudianteActividadesController(IQueryService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Estudiantes> Get()
        {
            return _service.GetEstudianteCarreraPlan();
        }

        [HttpGet("{id}", Name = "Get")]
        public Estudiantes Get(string id)
        {
            return _service.GetEstudianteCarreraPlanById(id);
        }

        // POST: api/EstudianteActividades
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/EstudianteActividades/5
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

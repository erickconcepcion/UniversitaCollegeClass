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
    public class EstudianteCarrerasController : ControllerBase
    {
        private readonly IQueryService _service;
        public EstudianteCarrerasController(IQueryService service)
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
    }
}

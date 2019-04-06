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
    public class TipoProfesoresController : ControllerBase
    {
        private readonly IQueryService _service;

        public TipoProfesoresController(IQueryService service)
        {
            _service = service;
        }
        // GET: api/TipoProfesores
        [HttpGet]
        public IEnumerable<ProfesoresTipos> Get()
        {
            return _service.GetProfesoresPorTipo();
        }

        [HttpGet("{id}")]
        public ProfesoresTipos Get(int id)
        {
            return _service.GetProfesoresPorTipoById(id);
        }
    }
}

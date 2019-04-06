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
    public class MedioPagosController : ControllerBase
    {
        private readonly IQueryService _service;
        public MedioPagosController(IQueryService service)
        {
            _service = service;
        }
        // GET: api/MedioPagos
        [HttpGet]
        public IEnumerable<Mediosdepago> Get()
        {
            return _service.GetMedioDePago();
        }

        [HttpGet("{id}")]
        public Mediosdepago Get(int id)
        {
            return _service.GetMedioDePagoById(id);
        }
    }
}

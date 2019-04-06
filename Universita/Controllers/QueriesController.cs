using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Universita.Services;

namespace Universita.Controllers
{
    public class QueriesController : Controller
    {
        private readonly IQueryService _service;
        public QueriesController(IQueryService service)
        {
            _service = service;
        }
        // GET: Queries
        public ActionResult EstudianteActividades()
        {
            return View("EstudianteActividades", JsonConvert.SerializeObject(_service.GetEstudianteActividades()));
        }

        // GET: Queries/Details/5
        public ActionResult EstudianteCarreras(string id)
        {
            if (id!=null)
            {
                return View("EstudianteCarreras", JsonConvert.SerializeObject(_service.GetEstudianteCarreraPlanById(id)));
            }
            return View("EstudianteCarreras", JsonConvert.SerializeObject(_service.GetEstudianteCarreraPlan()));
        }

        // GET: Queries/Create
        public ActionResult MediosDePago(int? id)
        {
            if (id==null)
            {
                return View("MediosDePago", JsonConvert.SerializeObject(_service.GetMedioDePago()));
            }
            return View("MediosDePago", JsonConvert.SerializeObject(_service.GetMedioDePagoById(id.Value)));
        }
        
        public ActionResult TipoProfesores(int? id)
        {
            if (id==null)
            {
                return View("TipoProfesores", JsonConvert.SerializeObject(_service.GetProfesoresPorTipo()));
            }
            return View("TipoProfesores", JsonConvert.SerializeObject(_service.GetProfesoresPorTipoById(id.Value)));
        }

        
        public ActionResult EstudianteDirTels()
        {
            return View("EstudianteDirTels", JsonConvert.SerializeObject(_service.GetEstudianteDirTel()));
        }
        

    }
}
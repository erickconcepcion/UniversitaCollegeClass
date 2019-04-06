using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return View(_service.GetEstudianteActividades());
        }

        // GET: Queries/Details/5
        public ActionResult EstudianteCarreras()
        {
            return View(_service.GetEstudianteCarreraPlan());
        }

        // GET: Queries/Create
        public ActionResult MediosDePago()
        {
            return View(_service.GetMedioDePago());
        }

        public ActionResult TipoProfesores()
        {
            return View(_service.GetProfesoresPorTipo());
        }
        public ActionResult TipoProfesores(int id)
        {
            return View(_service.GetProfesoresPorTipoById(id));
        }
        public ActionResult EstudianteDirTels()
        {
            return View(_service.GetEstudianteDirTel());
        }
        
    }
}
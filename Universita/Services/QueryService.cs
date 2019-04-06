using Microsoft.EntityFrameworkCore;
using Servuniv.Data;
using Servuniv.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universita.Services
{
    public interface IQueryService
    {
        ICollection<Estudiantes> GetEstudianteCarreraPlan();
        Estudiantes GetEstudianteCarreraPlanById(string mat);
        ICollection<Estudiantes> GetEstudianteActividades();
        Estudiantes GetEstudianteActividadesById(string mat);
        ICollection<Estudiantes> GetEstudianteDirTel();
        Estudiantes GetEstudianteDirTelById(string mat);
        ICollection<ProfesoresTipos> GetProfesoresPorTipo();
        ProfesoresTipos GetProfesoresPorTipoById(int tp);
        ICollection<Mediosdepago> GetMedioDePago();
        Mediosdepago GetMedioDePagoById(int mp);

    }
    public class QueryService: IQueryService
    {
        private readonly ServunivContext _context;

        public QueryService(ServunivContext context)
        {
            _context = context;
        }
        public ICollection<Estudiantes> GetEstudianteCarreraPlan()
        {
            var estudiantes = _context.Estudiantes
                .Include(e => e.Plandeestudios)
                .Include(p => p.Plandeestudios.Carreras).ToList();
            foreach (var item in estudiantes)
            {
                removeEstRec(item);
            }
            return estudiantes;
        }
        public Estudiantes GetEstudianteCarreraPlanById(string mat)
            => GetEstudianteCarreraPlan().Where(e => e.Matricula == mat).FirstOrDefault();
        private void removeEstRec(Estudiantes est)
        {
            est.Plandeestudios.Estudiantes = null;
            est.Plandeestudios.Carreras.Plandeestudios = null;
        }
        private void removeEstActRec(Estudiantes est)
        {
            foreach (var item in est.EstudiantesExtracurriculares)
            {
                item.Estudiantes = null;
                item.Tipodeactividades.EstudiantesExtracurriculares = null;
            }
        }

        public ICollection<Estudiantes> GetEstudianteActividades()
        {
            var estudiantes = _context.Estudiantes.Include(e => e.EstudiantesExtracurriculares)
                .Include("EstudiantesExtracurriculares.Tipodeactividades").ToList();
            foreach (var item in estudiantes)
            {
                removeEstActRec(item);
            }
            return estudiantes;            
        }
        public Estudiantes GetEstudianteActividadesById(string mat)
            => GetEstudianteActividades().Where(e => e.Matricula == mat).FirstOrDefault();

        private void removeEstDirTelRec(Estudiantes est)
        {
            foreach (var item in est.EstudiantesDirecciones)
            {
                item.Estudiantes = null;
                item.Paises.EstudiantesDirecciones = null;
                item.Tipodedireccion.EstudiantesDirecciones = null;
                item.Ciudades.EstudiantesDirecciones = null;
                item.Sectores.EstudiantesDirecciones = null;
            }
            foreach (var item in est.EstudiantesTelefonos)
            {
                item.Estudiantes = null;
                item.Tipodetelefonos.EstudiantesTelefonos = null;
            }
        }
        public ICollection<Estudiantes> GetEstudianteDirTel()
        {
            var estudiantes = _context.Estudiantes.Include(e => e.EstudiantesDirecciones)
                .Include("EstudiantesDirecciones.Tipodedireccion")
                .Include("EstudiantesDirecciones.Paises")
                .Include("EstudiantesDirecciones.Ciudades")
                .Include("EstudiantesDirecciones.Sectores")
                .Include(e=>e.EstudiantesTelefonos)
                .Include("EstudiantesTelefonos.Tipodetelefonos").ToList();
            foreach (var item in estudiantes)
            {
                removeEstDirTelRec(item);
            }
            return estudiantes;
        }

        
        public Estudiantes GetEstudianteDirTelById(string mat)
            => GetEstudianteDirTel().Where(e => e.Matricula == mat).FirstOrDefault();

        private void removeTpRec(ProfesoresTipos tp)
        {
            foreach (var item in tp.Profesores)
            {
                item.ProfesoresTipos = null;
                item.Condiciones.Profesores = null;
            }
        }
        public ICollection<ProfesoresTipos> GetProfesoresPorTipo()
        {
            var profesores = _context.ProfesoresTipos
                .Include(tp => tp.Profesores)
                .Include("Profesores.Condiciones").ToList();
            foreach (var item in profesores)
            {
                removeTpRec(item);
            }
            return profesores;
        }
        public ProfesoresTipos GetProfesoresPorTipoById(int tp)
            => GetProfesoresPorTipo().Where(p => p.Idtipodeprofesor == tp).FirstOrDefault();

        private void removeMpRec(Mediosdepago tp)
        {
            foreach (var item in tp.EstudiantesPagos)
            {
                item.Mediosdepago = null;
                item.Estudiantes.EstudiantesPagos = null;
                item.Tipodepagos.EstudiantesPagos = null;
            }
        }
        public ICollection<Mediosdepago> GetMedioDePago()
        {
            var medios = _context.Mediosdepagos
                .Include(tp => tp.EstudiantesPagos)
                .Include("EstudiantesPagos.Estudiantes")
                .Include("EstudiantesPagos.Tipodepagos").ToList();
            foreach (var item in medios)
            {
                removeMpRec(item);
            }
            return medios;
        }
        public Mediosdepago GetMedioDePagoById(int mp)
            => GetMedioDePago().Where(p => p.Idmediodepago == mp).FirstOrDefault();

    }
}

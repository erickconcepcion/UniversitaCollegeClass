using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Servuniv.Data
{
    public partial class ServunivContext : DbContext
    {
        public ServunivContext(DbContextOptions<ServunivContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Servuniv.Data.Entities.Carreras> Carreras { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Ciudades> Ciudades { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Condiciones> Condiciones { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Estados> Estados { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Estudiantes> Estudiantes { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesConsultassalud> EstudiantesConsultassaluds { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesDatosdesalud> EstudiantesDatosdesaluds { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesExtracurriculares> EstudiantesExtracurriculares { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesPagos> EstudiantesPagos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesTelefonos> EstudiantesTelefonos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.EstudiantesTipos> EstudiantesTipos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Materias> Materias { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Medicos> Medicos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.MedicosTipos> MedicosTipos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Mediosdepago> Mediosdepagos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Paises> Paises { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Plandeestudios> Plandeestudios { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Profesores> Profesores { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.ProfesoresTipos> ProfesoresTipos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Sectores> Sectores { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Tipodeactividades> Tipodeactividades { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Tipodedireccion> Tipodedireccions { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Tipodepagos> Tipodepagos { get; set; }

        public virtual DbSet<Servuniv.Data.Entities.Tipodetelefonos> Tipodetelefonos { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.CarrerasMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.CiudadesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.CondicionesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstadosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesCalificacionesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesConsultassaludMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesDatosdesaludMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesDireccionesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesExtracurricularesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesPagosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesTelefonosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.EstudiantesTiposMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.MateriasMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.MedicosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.MedicosTiposMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.MediosdepagoMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.PaisesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.PlandeestudiosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.ProfesoresMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.ProfesoresTiposMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.SectoresMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.TipodeactividadesMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.TipodedireccionMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.TipodepagosMap());
            modelBuilder.ApplyConfiguration(new Servuniv.Data.Mapping.TipodetelefonosMap());
            #endregion
        }
    }
}

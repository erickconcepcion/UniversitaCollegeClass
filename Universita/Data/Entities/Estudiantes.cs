using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Estudiantes
    {
        public Estudiantes()
        {
            #region Generated Constructor
            EstudiantesCalificaciones = new HashSet<EstudiantesCalificaciones>();
            EstudiantesConsultassaluds = new HashSet<EstudiantesConsultassalud>();
            EstudiantesDatosdesaluds = new HashSet<EstudiantesDatosdesalud>();
            EstudiantesDirecciones = new HashSet<EstudiantesDirecciones>();
            EstudiantesExtracurriculares = new HashSet<EstudiantesExtracurriculares>();
            EstudiantesPagos = new HashSet<EstudiantesPagos>();
            EstudiantesTelefonos = new HashSet<EstudiantesTelefonos>();
            #endregion
        }

        #region Generated Properties
        public string Matricula { get; set; }

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime Nacimiento { get; set; }

        public DateTime Ingreso { get; set; }

        public bool Trabaja { get; set; }

        public string Idcarrera { get; set; }

        public int Idplan { get; set; }

        public int Idtipo { get; set; }

        public double Indice { get; set; }

        public int Idcondicion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Condiciones Condiciones { get; set; }

        public virtual EstudiantesTipos EstudiantesTipos { get; set; }

        public virtual Plandeestudios Plandeestudios { get; set; }

        public virtual ICollection<EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual ICollection<EstudiantesConsultassalud> EstudiantesConsultassaluds { get; set; }

        public virtual ICollection<EstudiantesDatosdesalud> EstudiantesDatosdesaluds { get; set; }

        public virtual ICollection<EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        public virtual ICollection<EstudiantesExtracurriculares> EstudiantesExtracurriculares { get; set; }

        public virtual ICollection<EstudiantesPagos> EstudiantesPagos { get; set; }

        public virtual ICollection<EstudiantesTelefonos> EstudiantesTelefonos { get; set; }

        #endregion

    }
}

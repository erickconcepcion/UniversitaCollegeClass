using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Profesores
    {
        public Profesores()
        {
            #region Generated Constructor
            EstudiantesCalificaciones = new HashSet<EstudiantesCalificaciones>();
            #endregion
        }

        #region Generated Properties
        public int Idprofesor { get; set; }

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime Nacimiento { get; set; }

        public DateTime Ingreso { get; set; }

        public bool Trabaja { get; set; }

        public int Idtipodeprofesor { get; set; }

        public int Idcondicion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual Condiciones Condiciones { get; set; }

        public virtual ProfesoresTipos ProfesoresTipos { get; set; }

        #endregion

    }
}

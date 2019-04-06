using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Plandeestudios
    {
        public Plandeestudios()
        {
            #region Generated Constructor
            Estudiantes = new HashSet<Estudiantes>();
            EstudiantesCalificaciones = new HashSet<EstudiantesCalificaciones>();
            Materias = new HashSet<Materias>();
            #endregion
        }

        #region Generated Properties
        public int Idplan { get; set; }

        public int Idcarrera { get; set; }

        public DateTime Fecha { get; set; }

        public int Idestado { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }

        public virtual ICollection<EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual ICollection<Materias> Materias { get; set; }

        public virtual Carreras Carreras { get; set; }

        #endregion

    }
}

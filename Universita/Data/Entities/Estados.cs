using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Estados
    {
        public Estados()
        {
            #region Generated Constructor
            EstudiantesCalificaciones = new HashSet<EstudiantesCalificaciones>();
            EstudiantesExtracurriculares = new HashSet<EstudiantesExtracurriculares>();
            Materias = new HashSet<Materias>();
            #endregion
        }

        #region Generated Properties
        public int Idestado { get; set; }

        public string Estado { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual ICollection<EstudiantesExtracurriculares> EstudiantesExtracurriculares { get; set; }

        public virtual ICollection<Materias> Materias { get; set; }

        #endregion

    }
}

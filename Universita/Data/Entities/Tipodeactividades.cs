using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Tipodeactividades
    {
        public Tipodeactividades()
        {
            #region Generated Constructor
            EstudiantesExtracurriculares = new HashSet<EstudiantesExtracurriculares>();
            #endregion
        }

        #region Generated Properties
        public int Idtipoactividad { get; set; }

        public string Descripcionactividad { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesExtracurriculares> EstudiantesExtracurriculares { get; set; }

        #endregion

    }
}

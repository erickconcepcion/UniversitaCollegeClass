using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesTipos
    {
        public EstudiantesTipos()
        {
            #region Generated Constructor
            Estudiantes = new HashSet<Estudiantes>();
            #endregion
        }

        #region Generated Properties
        public int Idtipo { get; set; }

        public string Tipo { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }

        #endregion

    }
}

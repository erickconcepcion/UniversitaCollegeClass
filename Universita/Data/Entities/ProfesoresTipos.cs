using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class ProfesoresTipos
    {
        public ProfesoresTipos()
        {
            #region Generated Constructor
            Profesores = new HashSet<Profesores>();
            #endregion
        }

        #region Generated Properties
        public int Idtipodeprofesor { get; set; }

        public string Tipodeprofesor { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Profesores> Profesores { get; set; }

        #endregion

    }
}

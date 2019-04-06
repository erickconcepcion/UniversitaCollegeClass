using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Tipodedireccion
    {
        public Tipodedireccion()
        {
            #region Generated Constructor
            EstudiantesDirecciones = new HashSet<EstudiantesDirecciones>();
            #endregion
        }

        #region Generated Properties
        public int Idtipodedireccion { get; set; }

        public string TipodedireccionMember { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        #endregion

    }
}

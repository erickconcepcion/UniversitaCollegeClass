using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Tipodetelefonos
    {
        public Tipodetelefonos()
        {
            #region Generated Constructor
            EstudiantesTelefonos = new HashSet<EstudiantesTelefonos>();
            #endregion
        }

        #region Generated Properties
        public int Idtipodetelefono { get; set; }

        public string Tipodetelefono { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesTelefonos> EstudiantesTelefonos { get; set; }

        #endregion

    }
}

using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Tipodepagos
    {
        public Tipodepagos()
        {
            #region Generated Constructor
            EstudiantesPagos = new HashSet<EstudiantesPagos>();
            #endregion
        }

        #region Generated Properties
        public int Idtipodepago { get; set; }

        public string Tipodepago { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesPagos> EstudiantesPagos { get; set; }

        #endregion

    }
}

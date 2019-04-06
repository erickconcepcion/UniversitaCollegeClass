using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Mediosdepago
    {
        public Mediosdepago()
        {
            #region Generated Constructor
            EstudiantesPagos = new HashSet<EstudiantesPagos>();
            #endregion
        }

        #region Generated Properties
        public int Idmediodepago { get; set; }

        public string Mediodepago { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesPagos> EstudiantesPagos { get; set; }

        #endregion

    }
}

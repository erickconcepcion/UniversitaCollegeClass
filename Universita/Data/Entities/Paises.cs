using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Paises
    {
        public Paises()
        {
            #region Generated Constructor
            EstudiantesDirecciones = new HashSet<EstudiantesDirecciones>();
            #endregion
        }

        #region Generated Properties
        public int Idpais { get; set; }

        public string Pais { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        #endregion

    }
}

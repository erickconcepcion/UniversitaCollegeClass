using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Sectores
    {
        public Sectores()
        {
            #region Generated Constructor
            EstudiantesDirecciones = new HashSet<EstudiantesDirecciones>();
            #endregion
        }

        #region Generated Properties
        public int Idsector { get; set; }

        public string Sector { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        #endregion

    }
}

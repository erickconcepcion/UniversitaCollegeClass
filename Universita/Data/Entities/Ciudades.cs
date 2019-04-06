using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            #region Generated Constructor
            EstudiantesDirecciones = new HashSet<EstudiantesDirecciones>();
            #endregion
        }

        #region Generated Properties
        public int Idciudad { get; set; }

        public string Ciudad { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesDirecciones> EstudiantesDirecciones { get; set; }

        #endregion

    }
}

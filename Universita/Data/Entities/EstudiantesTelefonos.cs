using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesTelefonos
    {
        public EstudiantesTelefonos()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Idtelefono { get; set; }

        public string Matricula { get; set; }

        public int Codigodearea { get; set; }

        public int Codigodepais { get; set; }

        public int Telefono { get; set; }

        public int Idtipodetelefono { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Tipodetelefonos Tipodetelefonos { get; set; }

        #endregion

    }
}

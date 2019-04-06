using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesDirecciones
    {
        public EstudiantesDirecciones()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Iddireccion { get; set; }

        public string Matricula { get; set; }

        public int Idtipodedireccion { get; set; }

        public string Calle { get; set; }

        public int Numero { get; set; }

        public int Idsector { get; set; }

        public int Idciudad { get; set; }

        public int Idpais { get; set; }

        public int Codigopostal { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Ciudades Ciudades { get; set; }

        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Paises Paises { get; set; }

        public virtual Sectores Sectores { get; set; }

        public virtual Tipodedireccion Tipodedireccion { get; set; }

        #endregion

    }
}

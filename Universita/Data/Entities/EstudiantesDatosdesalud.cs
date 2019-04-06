using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesDatosdesalud
    {
        public EstudiantesDatosdesalud()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Iddatossalud { get; set; }

        public string Matricula { get; set; }

        public string Encasoemergencia { get; set; }

        public string Tiposangre { get; set; }

        public string Rh { get; set; }

        public string Alergias { get; set; }

        public string Padecimientos { get; set; }

        public string Tratamientos { get; set; }

        public string Nombremedico { get; set; }

        public string Telefonomedico { get; set; }

        public string Centromedico { get; set; }

        public string Telefonocentromedico { get; set; }

        public string Extension { get; set; }

        public string Seguromedico { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estudiantes Estudiantes { get; set; }

        #endregion

    }
}

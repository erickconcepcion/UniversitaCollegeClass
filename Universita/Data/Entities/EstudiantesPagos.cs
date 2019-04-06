using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesPagos
    {
        public EstudiantesPagos()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Idpago { get; set; }

        public string Matricula { get; set; }

        public DateTime Fecha { get; set; }

        public double Monto { get; set; }

        public int Idtipodepago { get; set; }

        public int Idmediodepago { get; set; }

        public int Numerodeautorizacion { get; set; }

        public int Cuentacontable { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Mediosdepago Mediosdepago { get; set; }

        public virtual Tipodepagos Tipodepagos { get; set; }

        #endregion

    }
}

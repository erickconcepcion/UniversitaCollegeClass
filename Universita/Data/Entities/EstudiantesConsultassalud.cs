using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesConsultassalud
    {
        public EstudiantesConsultassalud()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Idsalud { get; set; }

        public string Matricula { get; set; }

        public int Idmedico { get; set; }

        public int Iddiagnostico { get; set; }

        public string Diagnostico { get; set; }

        public DateTime Fecha { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Medicos Medicos { get; set; }

        #endregion

    }
}

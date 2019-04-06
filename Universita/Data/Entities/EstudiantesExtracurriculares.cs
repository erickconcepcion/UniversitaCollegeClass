using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesExtracurriculares
    {
        public EstudiantesExtracurriculares()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Idextracurricular { get; set; }

        public string Matricula { get; set; }

        public int Idtipoactividad { get; set; }

        public int Actividad { get; set; }

        public DateTime Fecha { get; set; }

        public double Horas { get; set; }

        public int Idestado { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estados Estados { get; set; }

        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Tipodeactividades Tipodeactividades { get; set; }

        #endregion

    }
}

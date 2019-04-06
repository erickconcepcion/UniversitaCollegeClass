using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class EstudiantesCalificaciones
    {
        public EstudiantesCalificaciones()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Idregistro { get; set; }

        public string Matricula { get; set; }

        public int Idcarrera { get; set; }

        public int Idplan { get; set; }

        public int Idmateria { get; set; }

        public string Grupo { get; set; }

        public DateTime Cursada { get; set; }

        public double Notaparcial1 { get; set; }

        public double Notaparcial2 { get; set; }

        public double Notafinal { get; set; }

        public int Idprofesor { get; set; }

        public int Idestado { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Estados Estados { get; set; }

        public virtual Carreras Carreras { get; set; }

        public virtual Estudiantes Estudiantes { get; set; }

        public virtual Plandeestudios Plandeestudios { get; set; }

        public virtual Profesores Profesores { get; set; }

        #endregion

    }
}

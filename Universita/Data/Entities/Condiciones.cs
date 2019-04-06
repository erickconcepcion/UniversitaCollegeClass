using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Condiciones
    {
        public Condiciones()
        {
            #region Generated Constructor
            Estudiantes = new HashSet<Estudiantes>();
            Profesores = new HashSet<Profesores>();
            #endregion
        }

        #region Generated Properties
        public int Idcondicion { get; set; }

        public string Condicion { get; set; }

        public bool Esprofesor { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }

        public virtual ICollection<Profesores> Profesores { get; set; }

        #endregion

    }
}

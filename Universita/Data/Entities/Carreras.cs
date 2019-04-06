using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Carreras
    {
        public Carreras()
        {
            #region Generated Constructor
            EstudiantesCalificaciones = new HashSet<EstudiantesCalificaciones>();
            Materias = new HashSet<Materias>();
            Plandeestudios = new HashSet<Plandeestudios>();
            #endregion
        }

        #region Generated Properties
        public int Idcarrera { get; set; }

        public int Idestado { get; set; }

        public string Carrera { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesCalificaciones> EstudiantesCalificaciones { get; set; }

        public virtual ICollection<Materias> Materias { get; set; }

        public virtual ICollection<Plandeestudios> Plandeestudios { get; set; }

        #endregion

    }
}

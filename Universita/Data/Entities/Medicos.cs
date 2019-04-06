using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Medicos
    {
        public Medicos()
        {
            #region Generated Constructor
            EstudiantesConsultassaluds = new HashSet<EstudiantesConsultassalud>();
            #endregion
        }

        #region Generated Properties
        public int Idmedico { get; set; }

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime Nacimiento { get; set; }

        public DateTime Ingreso { get; set; }

        public bool Trabaja { get; set; }

        public int Idtipodemedico { get; set; }

        public int Idcondicion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EstudiantesConsultassalud> EstudiantesConsultassaluds { get; set; }

        public virtual MedicosTipos MedicosTipos { get; set; }

        #endregion

    }
}

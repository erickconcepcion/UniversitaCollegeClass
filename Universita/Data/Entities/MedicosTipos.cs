using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class MedicosTipos
    {
        public MedicosTipos()
        {
            #region Generated Constructor
            Medicos = new HashSet<Medicos>();
            #endregion
        }

        #region Generated Properties
        public int Idtipodemedico { get; set; }

        public string Tipodemedico { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Medicos> Medicos { get; set; }

        #endregion

    }
}

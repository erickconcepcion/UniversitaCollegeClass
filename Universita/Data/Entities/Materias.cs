using System;
using System.Collections.Generic;

namespace Servuniv.Data.Entities
{
    public partial class Materias
    {
        public Materias()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public string Idmateria { get; set; }

        public string Materia { get; set; }

        public int Idcarrera { get; set; }

        public int Idplan { get; set; }

        public DateTime Revisada { get; set; }

        public int Idestado { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Carreras Carreras { get; set; }

        public virtual Estados Estados { get; set; }

        public virtual Plandeestudios Plandeestudios { get; set; }

        #endregion

    }
}

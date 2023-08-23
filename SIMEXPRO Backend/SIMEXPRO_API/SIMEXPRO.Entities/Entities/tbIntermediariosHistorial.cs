
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbIntermediariosHistorial
    {
        public int hint_Id { get; set; }
        public int inte_Id { get; set; }
        public int tite_Id { get; set; }
        public string inte_Tipo_Otro { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime inte_FechaCreacion { get; set; }
        public int himp_UsuarioModificacion { get; set; }
        public DateTime himp_FechaModificacion { get; set; }

        public virtual tbIntermediarios inte { get; set; }
    }
}
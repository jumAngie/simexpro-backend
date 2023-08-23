
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImportadoresHistorial
    {
        public int himp_Id { get; set; }
        public int impo_Id { get; set; }
        public int nico_Id { get; set; }
        public int decl_Id { get; set; }
        public string impo_NivelComercial_Otro { get; set; }
        public string impo_RTN { get; set; }
        public string impo_NumRegistro { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime impo_FechaCreacion { get; set; }
        public int himp_UsuarioModificacion { get; set; }
        public DateTime himp_FechaModificacion { get; set; }

        public virtual tbImportadores impo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ImportadoresViewModel
    {
        public int impo_Id { get; set; }
        public int nico_Id { get; set; }
        public int decl_Id { get; set; }
        public string impo_NivelComercial_Otro { get; set; }
        public string impo_RTN { get; set; }
        public string impo_NumRegistro { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime impo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? impo_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? impo_FechaEliminacion { get; set; }
        public bool? impo_Estado { get; set; }
    }
}

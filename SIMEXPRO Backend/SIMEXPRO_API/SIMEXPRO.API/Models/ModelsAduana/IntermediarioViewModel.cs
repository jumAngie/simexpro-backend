using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class IntermediarioViewModel
    {
        public int inte_Id { get; set; }
        public int tite_Id { get; set; }
        public string inte_Tipo_Otro { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime inte_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? inte_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? inte_FechaEliminacion { get; set; }
        public bool? inte_Estado { get; set; }
    }
}

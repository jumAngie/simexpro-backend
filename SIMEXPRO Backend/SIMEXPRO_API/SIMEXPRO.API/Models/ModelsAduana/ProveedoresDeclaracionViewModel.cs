using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ProveedoresDeclaracionViewModel
    {
        public int pvde_Id { get; set; }
        public int coco_Id { get; set; }
        public string pvde_Condicion_Otra { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pvde_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pvde_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? pvde_FechaEliminacion { get; set; }
        public bool? pvde_Estado { get; set; }
    }
}

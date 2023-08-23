using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TiposIdentificacionViewModel
    {
        public int iden_Id { get; set; }
        public string iden_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime iden_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? iden_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? iden_FechaEliminacion { get; set; }
        public bool? iden_Estado { get; set; }

        public string usuarioCreacionNombre { get; set; }
        public string? usuarioModificacionNombre { get; set; }
        public string? usuarioEliminacionNombre { get; set; }
    }
}

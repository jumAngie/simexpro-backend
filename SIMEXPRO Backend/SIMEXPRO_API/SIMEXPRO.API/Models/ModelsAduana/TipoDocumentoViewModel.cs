using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TipoDocumentoViewModel
    {
        public int tido_Id { get; set; }
        public string tido_Codigo { get; set; }
        public string tido_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }

         public string? usarioCreacion { get; set; }
        public DateTime tido_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

         public string? usuarioModificacion { get; set; }
        public DateTime? tido_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tido_FechaEliminacion { get; set; }
        public bool? tido_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class LugaresEmbarqueViewModel
    {
        public int emba_Id { get; set; }
        public string emba_Codigo { get; set; }
        public string emba_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
         public string usuarioCreacionNombre { get; set; }
        public DateTime emba_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
         public string usuarioModificacionNombre { get; set; }
        public DateTime? emba_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
         public string usuarioEliminacionNombre { get; set; }
        public DateTime? emba_FechaEliminacion { get; set; }
        public bool? emba_Estado { get; set; }
    }
}

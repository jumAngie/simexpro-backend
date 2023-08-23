using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class UnidadMedidaViewModel
    {
        public int unme_Id { get; set; }
        public string unme_Descripcion { get; set; }
        public bool unme_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime unme_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? unme_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? unme_FechaEliminacion { get; set; }
        public bool? unme_Estado { get; set; }

        public string usuarioCreacionNombre { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public string usuarioEliminacionNombre { get; set; }
    }
}

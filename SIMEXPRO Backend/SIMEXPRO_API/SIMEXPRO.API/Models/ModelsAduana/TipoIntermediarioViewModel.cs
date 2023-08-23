using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TipoIntermediarioViewModel
    {
        public int tite_Id { get; set; }
        public string tite_Codigo { get; set; }
        public string tite_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tite_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tite_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tite_FechaEliminacion { get; set; }
        public bool? tite_Estado { get; set; }
         public string usarioCreacion { get; set; }

         public string usuarioModificacion { get; set; }

    }
}

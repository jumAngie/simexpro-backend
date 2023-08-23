using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TipoLiquidacionViewModel
    {
        public int tipl_Id { get; set; }
        public string tipl_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tipl_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tipl_FechaModificacion { get; set; }
        public bool? tipl_Estado { get; set; }

         public string usarioCreacion { get; set; }

         public string usuarioModificacion { get; set; }

    }
}

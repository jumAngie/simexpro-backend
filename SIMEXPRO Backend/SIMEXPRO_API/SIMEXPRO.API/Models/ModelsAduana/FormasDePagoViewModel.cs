using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class FormasDePagoViewModel
    {
        public int fopa_Id { get; set; }
        public string fopa_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fopa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fopa_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? fopa_FechaEliminacion { get; set; }
        public bool? fopa_Estado { get; set; }

         public string usua_NombreCreacion { get; set; }

         public string usua_NombreModificacion { get; set; }
    }
}

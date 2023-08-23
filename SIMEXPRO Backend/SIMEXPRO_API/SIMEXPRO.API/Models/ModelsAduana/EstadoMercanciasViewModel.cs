using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class EstadoMercanciasViewModel
    {
        public int merc_Id { get; set; }
        public string merc_Codigo { get; set; }
        public string merc_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime merc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? merc_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? merc_FechaEliminacion { get; set; }
        public bool? merc_Estado { get; set; }

         public string usua_NombreCreacion { get; set; }

         public string usua_NombreModificacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class TallasViewModel
    {
        public int tall_Id { get; set; }
        public string tall_Codigo { get; set; }
        public string tall_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tall_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tall_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tall_FechaEliminacion { get; set; }
        public bool? tall_Estado { get; set; }

         public string usarioCreacion { get; set; }

         public string usuarioModificacion { get; set; }

    }
}

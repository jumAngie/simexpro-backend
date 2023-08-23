using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class EstilosViewModel
    {
        public int esti_Id { get; set; }
        public string esti_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime esti_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? esti_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? esti_FechaEliminacion { get; set; }
        public bool? esti_Estado { get; set; }

         public string usarioCreacion { get; set; }

         public string usuarioModificacion { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class MaquinaHistorialViewModel
    {

        public int mahi_Id { get; set; }
        public int maqu_Id { get; set; }

         public string MaquinaNumeroSerie { get; set; }
        public DateTime mahi_FechaInicio { get; set; }
        public DateTime mahi_FechaFin { get; set; }
        public string mahi_Observaciones { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime mahi_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? mahi_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? mahi_FechaEliminacion { get; set; }
        public bool? mahi_Estado { get; set; }

         public string usuarioCreacionNombre { get; set; }
         public string usuarioModificaNombre { get; set; }
         public string usuarioEliminaNombre { get; set; }


    }
}

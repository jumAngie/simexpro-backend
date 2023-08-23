using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class FuncionesMaquinaViewModel
    {
        public int func_Id { get; set; }
        public string func_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime func_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? func_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? func_FechaEliminacion { get; set; }
        public bool? func_Estado { get; set; }

         public string usuarioCreacionNombre { get; set; }

         public string usuarioModificacionNombre { get; set; }

         public string usuarioEliminacionNombre { get; set; }




    }
}

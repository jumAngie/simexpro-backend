using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class ProcesosViewModel
    {
        public int proc_Id { get; set; }
        public string proc_Descripcion { get; set; }
        public int modu_Id { get; set; }
        public string modu_Nombre { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
         public string usarioCreacion { get; set; }
        public DateTime proc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
         public string usuarioModificacion { get; set; }
        public DateTime? proc_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
         public string usuarioEliminacion { get; set; }
        public DateTime? proc_FechaEliminacion { get; set; }
        public bool? proc_Estado { get; set; }

    }
}

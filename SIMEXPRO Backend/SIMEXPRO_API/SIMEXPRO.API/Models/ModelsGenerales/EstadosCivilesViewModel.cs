using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
   public class EstadosCivilesViewModel
    {
        public int escv_Id { get; set; }
        public string escv_Nombre { get; set; }
        public bool? escv_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime escv_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? escv_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? escv_FechaEliminacion { get; set; }
        public bool? escv_Estado { get; set; }
        public string UsuarioCreacionNombre { get; set; }

        public string usuarioModificacionNombre { get; set; }
        

    }
}

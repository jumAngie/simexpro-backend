using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class CargosViewModel
    {
        public int carg_Id { get; set; }
        public string carg_Nombre { get; set; }

        public bool? carg_Aduana { get; set; }


        public int usua_UsuarioCreacion { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        public DateTime carg_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
     
        public DateTime? carg_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? carg_FechaEliminacion { get; set; }
        public bool? carg_Estado { get; set; }

    }
}

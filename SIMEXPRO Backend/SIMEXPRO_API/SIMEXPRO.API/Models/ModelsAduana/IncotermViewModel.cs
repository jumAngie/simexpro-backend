using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class IncotermViewModel
    {
        public int inco_Id { get; set; }
        public string inco_Codigo { get; set; }
        public string inco_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime inco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? inco_FechaModificacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }

        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? inco_FechaEliminacion { get; set; }
        public bool? inco_Estado { get; set; }
    }
}

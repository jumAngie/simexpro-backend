using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class AreasViewModel
    {
        public int tipa_Id { get; set; }
        public string tipa_area { get; set; }
        public int proc_Id { get; set; }

        [NotMapped]
        public string proc_Descripcion { get; set; }

        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usarioCreacion { get; set; }
        public DateTime tipa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }
        public DateTime? tipa_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacion { get; set; }
        public DateTime? tipa_FechaEliminacion { get; set; }
        public bool? tipa_Estado { get; set; }

    }
}

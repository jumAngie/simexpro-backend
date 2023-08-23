using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class AldeasViewModel
    {
        public int alde_Id { get; set; }
        public string alde_Nombre { get; set; }

        public int ciud_Id { get; set; }
        [NotMapped]
        public string ciud_Nombre { get; set; }

        [NotMapped]
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Codigo { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        public DateTime alde_FechaCreacion { get; set; }

        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? alde_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? alde_FechaEliminacion { get; set; }
        public bool? alde_Estado { get; set; }

    }
}

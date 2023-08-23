using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAcceso
{
    public class RolesViewModel
    {
        public int role_Id { get; set; }
        public string role_Descripcion { get; set; }
        public bool role_Aduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        public string Aduanero { get; set; }
        public string Detalles { get; set; }
        public string pant_Ids { get; set; }
        public DateTime role_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }

        public DateTime? role_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? role_FechaEliminacion { get; set; }
        public bool? role_Estado { get; set; }
    }
}

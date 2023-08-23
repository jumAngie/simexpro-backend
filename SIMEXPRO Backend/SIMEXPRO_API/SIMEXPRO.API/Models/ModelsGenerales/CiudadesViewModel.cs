using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class CiudadesViewModel
    {
        public int ciud_Id { get; set; }
        public string ciud_Nombre { get; set; }
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }
        [NotMapped]
        public string pvin_Codigo { get; set; }
        [NotMapped]
        public string pais_Codigo { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }
        public bool ciud_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime ciud_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? ciud_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioEliminacionNombre { get; set; }
        public DateTime? ciud_FechaEliminacion { get; set; }
        public bool? ciud_Estado { get; set; }
    }
}

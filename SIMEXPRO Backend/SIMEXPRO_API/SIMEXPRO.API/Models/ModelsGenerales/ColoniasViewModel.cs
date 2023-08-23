using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class ColoniasViewModel
    {
        public int colo_Id { get; set; }
        public string colo_Nombre { get; set; }
        public int? alde_Id { get; set; }
        [NotMapped]
        public string alde_Nombre { get; set; }
        public int? ciud_Id { get; set; }
        [NotMapped]
        public string ciud_Nombre { get; set; }
        [NotMapped]
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }
        [NotMapped]
        public string pvin_Codigo { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }
        [NotMapped]
        public string pais_Codigo { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime colo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public DateTime? colo_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }
        public DateTime? colo_FechaEliminacion { get; set; }
        public bool? colo_Estado { get; set; }

    }
}

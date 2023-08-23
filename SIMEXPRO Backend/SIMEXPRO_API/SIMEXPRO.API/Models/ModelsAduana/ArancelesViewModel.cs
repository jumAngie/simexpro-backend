using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ArancelesViewModel
    {
        public int aran_Id { get; set; }
        public string aran_Codigo { get; set; }
        public string aran_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacion { get; set; }
        public DateTime aran_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }
        public DateTime? aran_FechaModificacion { get; set; }
        public bool? aram_Estado { get; set; }

    }
}

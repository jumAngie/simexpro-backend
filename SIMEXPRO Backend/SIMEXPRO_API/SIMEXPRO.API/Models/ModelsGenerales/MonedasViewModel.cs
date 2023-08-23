using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class MonedasViewModel
    {
        public int mone_Id { get; set; }
        public string mone_Codigo { get; set; }
        public string mone_Descripcion { get; set; }
        public bool mone_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime mone_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime? mone_FechaModificacion { get; set; }
        public bool? mone_Estado { get; set; }
    }
}

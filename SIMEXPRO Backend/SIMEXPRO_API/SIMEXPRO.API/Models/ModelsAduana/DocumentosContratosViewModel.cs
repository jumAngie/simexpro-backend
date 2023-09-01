using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DocumentosContratosViewModel
    {
        public int doco_Id { get; set; }
        public int? coin_Id { get; set; }
        [NotMapped]
        public string pers_RTN { get; set; }
        [NotMapped]
        public string coin_CorreoElectronico { get; set; }
        [NotMapped]
        public string coin_TelefonoFijo { get; set; }
        public int? peju_Id { get; set; }
        public string doco_Numero_O_Referencia { get; set; }
        public string doco_TipoDocumento { get; set; }
        public string doco_NombreImagen { get; set; }
        public string doco_URLImagen { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime doco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? doco_FechaModificacion { get; set; }
        public bool? doco_Estado { get; set; }
    }
}

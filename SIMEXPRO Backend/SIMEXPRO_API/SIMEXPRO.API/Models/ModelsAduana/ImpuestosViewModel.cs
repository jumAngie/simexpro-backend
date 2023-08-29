using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ImpuestosViewModel
    {
        public int impu_Id { get; set; }
        public string aran_Codigo { get; set; }
        public string impu_Descripcion { get; set; }
        public decimal impu_Impuesto { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime impu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? impu_FechaModificacion { get; set; }
        public bool? impu_Estado { get; set; }
    }
}

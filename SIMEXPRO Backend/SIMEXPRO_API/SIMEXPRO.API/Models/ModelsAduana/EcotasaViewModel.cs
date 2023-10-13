using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class EcotasaViewModel
    {
        public int ecot_Id { get; set; }
        public decimal ecot_RangoIncial { get; set; }
        public decimal ecot_RangoFinal { get; set; }
        public decimal ecot_CantidadPagar { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ecot_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ecot_FechaModificacion { get; set; }
        public string usua_UsuarioCreacionNombre { get; set; }
        public string usua_UsuarioModificacionNombre { get; set; }
    }
}

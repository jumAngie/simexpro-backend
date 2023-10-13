using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ImpuestosSelectivoConsumoCondicionesVehiculosViewModel
    {
        public int selh_Id { get; set; }
        public bool? selh_EsNuevo { get; set; }
        public decimal? selh_RangoInicio { get; set; }
        public decimal? selh_RangoFin { get; set; }
        public decimal? selh_ImpuestoCobrar { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public DateTime? selh_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? selh_FechaModificacion { get; set; }
        public string usua_UsuarioCreacionNombre { get; set; }
        public string usua_UsuarioModificacionNombre { get; set; }
    }
}

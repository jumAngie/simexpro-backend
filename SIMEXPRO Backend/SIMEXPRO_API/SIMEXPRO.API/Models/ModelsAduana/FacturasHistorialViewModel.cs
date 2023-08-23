using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class FacturasHistorialViewModel
    {
        public int hfact_Id { get; set; }
        public int? fact_Id { get; set; }
        public int deva_Id { get; set; }
        public DateTime fect_Fecha { get; set; }
        public int? hfact_UsuarioAccion { get; set; }
        public DateTime? hfact_FechaAccion { get; set; }
        public string hfact_Accion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class LiquidacionGeneralHistorialViewModel
    {
        public int hlig_Id { get; set; }
        public int? lige_Id { get; set; }
        public decimal? lige_TipoTributo { get; set; }
        public string lige_TotalPorTributo { get; set; }
        public string lige_ModalidadPago { get; set; }
        public decimal? lige_TotalGral { get; set; }
        public string duca_Id { get; set; }
        public int? hlig_UsuarioAccion { get; set; }
        public DateTime hlig_FechaAccion { get; set; }
        public string hlig_Accion { get; set; }
    }
}

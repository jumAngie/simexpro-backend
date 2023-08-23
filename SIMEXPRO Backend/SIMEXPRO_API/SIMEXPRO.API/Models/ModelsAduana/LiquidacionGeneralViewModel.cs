using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class LiquidacionGeneralViewModel
    {
        public int lige_Id { get; set; }
        public string lige_TipoTributo { get; set; }
        public string lige_TotalPorTributo { get; set; }
        public string lige_ModalidadPago { get; set; }
        public string lige_TotalGral { get; set; }
        public string duca_Id { get; set; }
    }
}

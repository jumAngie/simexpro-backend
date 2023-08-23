using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class LiquidacionPorLineaViewModel
    {
        public int lili_Id { get; set; }
        public string lili_Tipo { get; set; }
        public decimal? lili_Alicuota { get; set; }
        public decimal? lili_Total { get; set; }
        public string lili_ModalidadPago { get; set; }
        public decimal? lili_TotalGral { get; set; }
        public int item_Id { get; set; }
    }
}

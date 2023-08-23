
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbLiquidacionPorLinea
    {
        public int lili_Id { get; set; }
        public string lili_Tipo { get; set; }
        public decimal? lili_Alicuota { get; set; }
        public decimal? lili_Total { get; set; }
        public string lili_ModalidadPago { get; set; }
        public decimal? lili_TotalGral { get; set; }
        public int item_Id { get; set; }

        public virtual tbItems item { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestosProd
    {
        public int impr_Id { get; set; }
        public string impr_Descripcion { get; set; }
        public decimal? impr_Valor { get; set; }
    }
}
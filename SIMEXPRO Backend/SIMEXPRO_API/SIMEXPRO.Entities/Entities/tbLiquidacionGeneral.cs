
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbLiquidacionGeneral
    {
        public tbLiquidacionGeneral()
        {
            tbBoletinPagoDetalles = new HashSet<tbBoletinPagoDetalles>();
            tbBoletinPago = new HashSet<tbBoletinPago>();
        }

        public int lige_Id { get; set; }
        public string lige_TipoTributo { get; set; }
        public string lige_TotalPorTributo { get; set; }
        public string lige_ModalidadPago { get; set; }
        public string lige_TotalGral { get; set; }
        public string duca_Id { get; set; }

        public virtual tbDuca duca { get; set; }
        public virtual ICollection<tbBoletinPago> tbBoletinPago { get; set; }
        public virtual ICollection<tbBoletinPagoDetalles> tbBoletinPagoDetalles { get; set; }
    }
}
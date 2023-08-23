using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbBoletinPagoDetalles
    {
        public int bode_Id { get; set; }
        public int boen_Id { get; set; }
        public int lige_Id { get; set; }
        public string bode_Concepto { get; set; }
        public string bode_TipoObligacion { get; set; }
        public int bode_CuentaPA01 { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime bode_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? bode_FechaModificacion { get; set; }

        public virtual tbLiquidacionGeneral lige { get; set; }
        public virtual tbBoletinPago boen { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
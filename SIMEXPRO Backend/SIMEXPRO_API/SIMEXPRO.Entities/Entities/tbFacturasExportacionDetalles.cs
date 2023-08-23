
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbFacturasExportacionDetalles
    {
        public int fede_Id { get; set; }
        public int faex_Id { get; set; }
        public int code_Id { get; set; }
        public int fede_Cajas { get; set; }
        public decimal fede_Cantidad { get; set; }
        public decimal fede_PrecioUnitario { get; set; }
        public decimal fede_TotalDetalle { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fede_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fede_FechaModificacion { get; set; }

        public virtual tbOrdenCompraDetalles code { get; set; }
        public virtual tbFacturasExportacion faex { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
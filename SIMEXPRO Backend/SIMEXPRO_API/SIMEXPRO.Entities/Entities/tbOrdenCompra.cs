
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbOrdenCompra
    {
        public tbOrdenCompra()
        {
            tbFacturasExportacion = new HashSet<tbFacturasExportacion>();
            tbOrdenCompraDetalles = new HashSet<tbOrdenCompraDetalles>();
            tbPODetallePorPedidoOrdenDetalle = new HashSet<tbPODetallePorPedidoOrdenDetalle>();
        }

        public int orco_Id { get; set; }
        public int orco_IdCliente { get; set; }
        public DateTime orco_FechaEmision { get; set; }
        public DateTime orco_FechaLimite { get; set; }
        public int orco_MetodoPago { get; set; }
        public bool orco_Materiales { get; set; }
        public int orco_IdEmbalaje { get; set; }
        public string orco_EstadoOrdenCompra { get; set; }
        public string orco_DireccionEntrega { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime orco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? orco_FechaModificacion { get; set; }
        public bool? orco_Estado { get; set; }

      
        [NotMapped]
        public string clie_Nombre_O_Razon_Social { get; set; }
        [NotMapped]
        public string clie_Direccion { get; set; }
        [NotMapped]
        public string clie_RTN { get; set; }
        [NotMapped]
        public string clie_Nombre_Contacto { get; set; }
        [NotMapped]
        public string clie_Numero_Contacto { get; set; }
        [NotMapped]
        public string clie_Correo_Electronico { get; set; }
        [NotMapped]
        public string clie_FAX { get; set; }


        [NotMapped]
        public string fopa_Descripcion { get; set; }


        [NotMapped]
        public string tiem_Descripcion { get; set; }


        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }        

        public virtual tbClientes orco_IdClienteNavigation { get; set; }
        public virtual tbTipoEmbalaje orco_IdEmbalajeNavigation { get; set; }
        public virtual tbFormasdePago orco_MetodoPagoNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetalles { get; set; }
        public virtual ICollection<tbFacturasExportacion> tbFacturasExportacion { get; set; }
        public virtual ICollection<tbPODetallePorPedidoOrdenDetalle> tbPODetallePorPedidoOrdenDetalle { get; set; }

    }
}
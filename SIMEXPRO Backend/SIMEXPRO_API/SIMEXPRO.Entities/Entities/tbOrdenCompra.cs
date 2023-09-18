
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
        public string orco_Codigo { get; set; }
        public bool orco_Materiales { get; set; }
        public int orco_IdEmbalaje { get; set; }
        public string orco_EstadoOrdenCompra { get; set; }
        public string orco_DireccionEntrega { get; set; }
        public bool orco_EstadoFinalizado { get; set; }
        [NotMapped]
        public string fopa_Descripcion { get; set; }
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
        public string tiem_Descripcion { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }        

        [NotMapped]
        public string Detalles { get; set; }

        public string? cate_Descripcion { get; set; }

        [NotMapped]
        public string? subc_Descripcion { get; set; }

        [NotMapped]
        public string? mate_Descripcion { get; set; }

        [NotMapped]
        public string? lote_Observaciones { get; set; }

        [NotMapped]
        public string? pais_Nombre { get; set; }

        [NotMapped]
        public string? pais_Codigo { get; set; }

        [NotMapped]
        public string? pvin_Nombre { get; set; }

        [NotMapped]
        public string? pvin_Codigo { get; set; }

        [NotMapped]
        public string? prov_Telefono { get; set; }

        [NotMapped]
        public string? prov_CorreoElectronico { get; set; }

        [NotMapped]
        public string? prov_NombreCompania { get; set; }

        [NotMapped]
        public string? colr_CodigoHtml { get; set; }

        [NotMapped]
        public string? colr_Codigo { get; set; }

        [NotMapped]
        public string? colr_Nombre { get; set; }

        [NotMapped]
        public string? tipa_area { get; set; }

        [NotMapped]
        public string? unme_Descripcion { get; set; }

        [NotMapped]
        public string? lote_CodigoLote { get; set; }

        [NotMapped]
        public string? tall_Codigo { get; set; }

        [NotMapped]
        public string? tall_Nombre { get; set; }

        [NotMapped]
        public string? code_Sexo { get; set; }

        [NotMapped]
        public string? esti_Descripcion { get; set; }

        [NotMapped]
        public int? ppde_Cantidad { get; set; }

        [NotMapped]
        public int? lote_Id { get; set; }

        [NotMapped]
        public DateTime? peor_FechaEntrada { get; set; }

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
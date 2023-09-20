using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class OrdenCompraViewModel
    {
        public int orco_Id { get; set; }
        public int orco_IdCliente { get; set; }
        public DateTime orco_FechaEmision { get; set; }
        public DateTime orco_FechaLimite { get; set; }
        public int orco_MetodoPago { get; set; }
        public bool orco_Materiales { get; set; }
        public int orco_IdEmbalaje { get; set; }
        public string orco_EstadoOrdenCompra { get; set; }
        [NotMapped]
        public string orco_EstadoFinalizado { get; set; }
        public string orco_Codigo{ get; set; }
        public string orco_DireccionEntrega { get; set; }
        public bool orco_EstadoFinalizado { get; set; }
        public string fopa_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime orco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? orco_FechaModificacion { get; set; }
        public bool? orco_Estado { get; set; }
        public string clie_Nombre_O_Razon_Social { get; set; }
        public string clie_Direccion { get; set; }
        public string clie_RTN { get; set; }
        public string clie_Nombre_Contacto { get; set; }
        public string clie_Numero_Contacto { get; set; }
        public string clie_Correo_Electronico { get; set; }
        public string clie_FAX { get; set; }
        public string tiem_Descripcion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public string Detalles { get; set; }
        public string? cate_Descripcion { get; set; }
        public string? subc_Descripcion { get; set; }
        public string? mate_Descripcion { get; set; }
        public string? lote_Observaciones { get; set; }
        public string? pais_Nombre { get; set; }
        public string? pais_Codigo { get; set; }
        public string? pvin_Nombre { get; set; }
        public string? pvin_Codigo { get; set; }
        public string? prov_Telefono { get; set; }
        public string? prov_CorreoElectronico { get; set; }
        public string? prov_NombreCompania { get; set; }
        public string? colr_CodigoHtml { get; set; }
        public string? colr_Codigo { get; set; }
        public string? colr_Nombre { get; set; }
        public string? tipa_area { get; set; }
        public string? unme_Descripcion { get; set; }
        public string? lote_CodigoLote { get; set; }
        public string? tall_Codigo { get; set; }
        public string? tall_Nombre { get; set; }
        public string? code_Sexo { get; set; }
        public string? esti_Descripcion { get; set; }
        public int? ppde_Cantidad { get; set; }
        public int? lote_Id { get; set; }
        public DateTime? peor_FechaEntrada { get; set; }
    }
}

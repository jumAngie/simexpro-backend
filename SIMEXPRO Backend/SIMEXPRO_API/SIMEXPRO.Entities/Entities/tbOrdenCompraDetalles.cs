
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbOrdenCompraDetalles
    {

        public tbOrdenCompraDetalles()
        {
            tbAsignacionesOrden = new HashSet<tbAsignacionesOrden>();
            tbLotes = new HashSet<tbLotes>();
            tbMaterialesBrindar = new HashSet<tbMaterialesBrindar>();
            tbOrde_Ensa_Acab_Etiq = new HashSet<tbOrde_Ensa_Acab_Etiq>();
            tbReporteModuloDiaDetalle = new HashSet<tbReporteModuloDiaDetalle>();
            tbFacturasExportacionDetalles = new HashSet<tbFacturasExportacionDetalles>();
            tbPODetallePorPedidoOrdenDetalle = new HashSet<tbPODetallePorPedidoOrdenDetalle>();
            tbDocumentosOrdenCompraDetalles = new HashSet<tbDocumentosOrdenCompraDetalles>();
        }

        public int code_Id { get; set; }
        public int orco_Id { get; set; }
        public int code_CantidadPrenda { get; set; }
        public int esti_Id { get; set; }
        [NotMapped]
        public string esti_Descripcion { get; set; }
        public int tall_Id { get; set; }

        [NotMapped]
        public string tall_Nombre { get; set; }

        public string code_Sexo { get; set; }
        public int colr_Id { get; set; }
        [NotMapped]
        public string colr_Nombre { get; set; }
        public string code_Documento { get; set; }
        public string code_Medidas { get; set; }
        public int proc_IdComienza { get; set; }
        [NotMapped]
        public string proc_DescripcionComienza { get; set; }
        public int proc_IdActual { get; set; }
        [NotMapped]
        public string proc_DescripcionActual { get; set; }
        public decimal code_Unidad { get; set; }
        public decimal code_Valor { get; set; }
        public decimal code_Impuesto { get; set; }
        public decimal code_Descuento { get; set; }
        public string code_EspecificacionEmbalaje { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        public DateTime? code_FechaProcActual { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime code_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string proc_Descripcion { get; set; }
        public DateTime? code_FechaModificacion { get; set; }
        public bool? code_Estado { get; set; }


       
        [NotMapped]
        public string orco_Codigo { get; set; }

        [NotMapped]
        public string clie_Nombre_O_Razon_Social { get; set; }

        [NotMapped]
        public bool orco_EstadoFinalizado { get; set; }

        [NotMapped]
        public string orco_EstadoOrdenCompra { get; set; }

        [NotMapped]
        public string proc_Actual { get; set; }

        [NotMapped]
        public string proc_Comienza { get; set; }

        [NotMapped]
        public int OrdenProduccion { get; set; }

        [NotMapped]
        public int faex_Id { get; set; }

        [NotMapped]
        public DateTime FechaExportacion { get; set; }

        [NotMapped]
        public decimal CantidadExportada { get; set; }

        [NotMapped]
        public int fede_Cajas { get; set; }

        [NotMapped]
        public decimal fede_TotalDetalle { get; set; }


        [NotMapped]
        public string SeguimientoProcesos { get; set; }

        [NotMapped]
        public string proc_CodigoHtml { get; set; }












        public virtual tbColores colr { get; set; }
        public virtual tbEstilos esti { get; set; }
        public virtual tbOrdenCompra orco { get; set; }
        public virtual tbProcesos proc_IdComienzaNavigation { get; set; }
        public virtual tbTallas tall { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

        public virtual ICollection<tbDocumentosOrdenCompraDetalles> tbDocumentosOrdenCompraDetalles { get; set; }
        public virtual ICollection<tbAsignacionesOrden> tbAsignacionesOrden { get; set; }
        public virtual ICollection<tbLotes> tbLotes { get; set; }
        public virtual ICollection<tbMaterialesBrindar> tbMaterialesBrindar { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiq { get; set; }
        public virtual ICollection<tbReporteModuloDiaDetalle> tbReporteModuloDiaDetalle { get; set; }
        public virtual ICollection<tbFacturasExportacionDetalles> tbFacturasExportacionDetalles { get; set; }
        public virtual ICollection<tbPODetallePorPedidoOrdenDetalle> tbPODetallePorPedidoOrdenDetalle { get; set; }

        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalle { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DocumentosPDFHistorialViewModel
    {
        public int hdev_Id { get; set; }
        public int? deva_Id { get; set; }
        public int deva_Aduana_Ingreso_Id { get; set; }
        public int deva_Aduana_Despacho_Id { get; set; }
        public string deva_Declaracion_Mercancia { get; set; }
        public DateTime? deva_Fecha_Aceptacion { get; set; }
        public int? impo_Id { get; set; }
        public int? pvde_Id { get; set; }
        public int? inte_Id { get; set; }
        public string deva_Lugar_Entrega { get; set; }
        public int? inco_Id { get; set; }
        public string deva_numero_contrato { get; set; }
        public DateTime? deva_Fecha_Contrato { get; set; }
        public int? foen_Id { get; set; }
        public string deva_Forma_Envio_Otra { get; set; }
        public bool? deva_Pago_Efectuado { get; set; }
        public int? fopa_Id { get; set; }
        public string deva_Forma_Pago_Otra { get; set; }
        public int? emba_Id { get; set; }
        public int? pais_Exportacion_Id { get; set; }
        public DateTime? deva_Fecha_Exportacion { get; set; }
        public int? mone_Id { get; set; }
        public string mone_Otra { get; set; }
        public decimal? deva_Conversion_Dolares { get; set; }
        public string deva_Condiciones { get; set; }
        public int? hdev_UsuarioAccion { get; set; }
        public DateTime? hdev_FechaAccion { get; set; }
        public string hdev_Accion { get; set; }
    }
}

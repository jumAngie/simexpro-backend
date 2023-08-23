
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDeclaraciones_ValorHistorial
    {
        public int hdev_Id { get; set; }
        public int? deva_Id { get; set; }
        public int deva_AduanaIngresoId { get; set; }
        public int deva_AduanaDespachoId { get; set; }
        public string deva_DeclaracionMercancia { get; set; }
        public DateTime? deva_FechaAceptacion { get; set; }
        public int? impo_Id { get; set; }
        public int? pvde_Id { get; set; }
        public int? inte_Id { get; set; }
        public string deva_LugarEntrega { get; set; }
        public int? pais_EntregaId { get; set; }
        public int? inco_Id { get; set; }
        public string inco_Version { get; set; }
        public string deva_NumeroContrato { get; set; }
        public DateTime? deva_FechaContrato { get; set; }
        public int? foen_Id { get; set; }
        public string deva_FormaEnvioOtra { get; set; }
        public bool? deva_PagoEfectuado { get; set; }
        public int? fopa_Id { get; set; }
        public string deva_FormaPagoOtra { get; set; }
        public int? emba_Id { get; set; }
        public int? pais_ExportacionId { get; set; }
        public DateTime? deva_FechaExportacion { get; set; }
        public int? mone_Id { get; set; }
        public string mone_Otra { get; set; }
        public decimal? deva_ConversionDolares { get; set; }
        public string deva_Condiciones { get; set; }
        public int? hdev_UsuarioAccion { get; set; }
        public DateTime? hdev_FechaAccion { get; set; }
        public string hdev_Accion { get; set; }
    }
}
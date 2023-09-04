
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class VW_tbDeclaraciones_ValorCompleto
    {
        public int deva_Id { get; set; }
        public int deva_AduanaIngresoId { get; set; }
        public string adua_IngresoNombre { get; set; }
        public int deva_AduanaDespachoId { get; set; }
        public string adua_DespachoNombre { get; set; }
        public string deva_DeclaracionMercancia { get; set; }
        public DateTime? deva_FechaAceptacion { get; set; }
        public bool? deva_Finalizacion { get; set; }
        public int? impo_Id { get; set; }
        public string impo_NumRegistro { get; set; }
        public int? nico_Id { get; set; }
        public string nico_Descripcion { get; set; }
        public string impo_NivelComercial_Otro { get; set; }
        public string impo_Nombre_Raso { get; set; }
        public string impo_Direccion_Exacta { get; set; }
        public string impo_Correo_Electronico { get; set; }
        public string impo_Telefono { get; set; }
        public string impo_Fax { get; set; }
        public int? impo_ciudId { get; set; }
        public int? pvde_Id { get; set; }
        public string prov_Nombre_Raso { get; set; }
        public string prov_Direccion_Exacta { get; set; }
        public string prov_Correo_Electronico { get; set; }
        public string prov_Telefono { get; set; }
        public string prov_Fax { get; set; }
        public int? prov_ciudId { get; set; }
        public int? coco_Id { get; set; }
        public string coco_Descripcion { get; set; }
        public string pvde_Condicion_Otra { get; set; }
        public int? inte_Id { get; set; }
        public int? tite_Id { get; set; }
        public string inte_Nombre_Raso { get; set; }
        public string inte_Direccion_Exacta { get; set; }
        public string inte_Correo_Electronico { get; set; }
        public string inte_Telefono { get; set; }
        public string inte_Fax { get; set; }
        public int? inte_ciudId { get; set; }
        public string deva_LugarEntrega { get; set; }
        public int? pais_EntregaId { get; set; }
        public string pais_EntregaNombre { get; set; }
        public int? inco_Id { get; set; }
        public string inco_Descripcion { get; set; }
        public string inco_Version { get; set; }
        public string deva_NumeroContrato { get; set; }
        public DateTime? deva_FechaContrato { get; set; }
        public int? foen_Id { get; set; }
        public string foen_Descripcion { get; set; }
        public string deva_FormaEnvioOtra { get; set; }
        public bool? deva_PagoEfectuado { get; set; }
        public int? fopa_Id { get; set; }
        public string deva_FormaPagoOtra { get; set; }
        public int? emba_Id { get; set; }
        public int? pais_ExportacionId { get; set; }
        public string pais_ExportacionNombre { get; set; }
        public DateTime? deva_FechaExportacion { get; set; }
        public int? mone_Id { get; set; }
        public string mone_Otra { get; set; }
        public decimal? deva_ConversionDolares { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public string usua_CreacionNombre { get; set; }
        public DateTime? deva_FechaCreacion { get; set; }
        public int? usua_ModificacionNombre { get; set; }
        public DateTime? deva_FechaModificacion { get; set; }
        public bool deva_Estado { get; set; }
    }
}
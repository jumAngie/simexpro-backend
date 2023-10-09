
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable
namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDeclaraciones_Valor
    {
        public tbDeclaraciones_Valor()
        {
            tbBaseCalculos = new HashSet<tbBaseCalculos>();
            tbCondiciones = new HashSet<tbCondiciones>();
            tbDocumentosPDF = new HashSet<tbDocumentosPDF>();
            tbDuca = new HashSet<tbDuca>();
            tbFacturas = new HashSet<tbFacturas>();
            tbItemsDEVAPorDuca = new HashSet<tbItemsDEVAPorDuca>();
        }

        public int deva_Id { get; set; }
        public int deva_AduanaIngresoId { get; set; }
        [NotMapped]
        public string adua_IngresoNombre { get; set; }
        public int deva_AduanaDespachoId { get; set; }
        [NotMapped]
        public string adua_DespachoNombre { get; set; }
        public string deva_DeclaracionMercancia { get; set; }
        public DateTime? deva_FechaAceptacion { get; set; }
        [NotMapped]
        public int regi_Id { get; set; }
        [NotMapped]
        public string regi_Codigo { get; set; }
        [NotMapped]
        public string regi_Descripcion { get; set; }
        public int? impo_Id { get; set; }
        [NotMapped]
        public string impo_NumRegistro { get; set; }
        [NotMapped]
        public int nico_Id { get; set; }
        [NotMapped]
        public string nico_Descripcion { get; set; }
        [NotMapped]
        public string impo_NivelComercial_Otro { get; set; }
        [NotMapped]
        public string impo_Nombre_Raso { get; set; }
        [NotMapped]
        public string impo_Direccion_Exacta { get; set; }
        [NotMapped]
        public string impo_Correo_Electronico { get; set; }
        [NotMapped]
        public string impo_Telefono { get; set; }
        [NotMapped]
        public string impo_Fax { get; set; }
        [NotMapped]
        public int impo_ciudId { get; set; }
        [NotMapped]
        public int? pvde_Id { get; set; }
        [NotMapped]
        public string prov_Nombre_Raso { get; set; }
        [NotMapped]
        public string prov_Direccion_Exacta { get; set; }
        [NotMapped]
        public string prov_Correo_Electronico { get; set; }
        [NotMapped]
        public string prov_Telefono { get; set; }
        [NotMapped]
        public string prov_Fax { get; set; }
        [NotMapped]
        public int prov_ciudId { get; set; }
        [NotMapped]
        public int coco_Id { get; set; }
        [NotMapped]
        public string coco_Descripcion { get; set; }
        [NotMapped]
        public string pvde_Condicion_Otra { get; set; }
        public int? inte_Id { get; set; }
        [NotMapped]
        public int tite_Id { get; set; }
        [NotMapped]
        public string inte_Nombre_Raso { get; set; }
        [NotMapped]
        public string inte_Direccion_Exacta { get; set; }
        [NotMapped]
        public string inte_Correo_Electronico { get; set; } 
        [NotMapped]
        public string inte_Telefono { get; set; }
        [NotMapped]
        public string inte_Fax { get; set; }
        [NotMapped]
        public int inte_ciudId { get; set; }

        [NotMapped]
        public string Facturas { get; set; }

        public string deva_LugarEntrega { get; set; }
        public int? pais_EntregaId { get; set; }
        public int? inco_Id { get; set; }
        [NotMapped]
        public string inco_Codigo { get; set; }
        [NotMapped]
        public string inco_Descripcion { get; set; }
        public string inco_Version { get; set; }
        public string deva_NumeroContrato { get; set; }
        public DateTime? deva_FechaContrato { get; set; }
        public int? foen_Id { get; set; }
        [NotMapped]
        public string foen_Descripcion { get; set; }
        public string deva_FormaEnvioOtra { get; set; }
        public bool? deva_PagoEfectuado { get; set; }
        public int? fopa_Id { get; set; }
        public string deva_FormaPagoOtra { get; set; }
        public int? emba_Id { get; set; }
        public int? pais_ExportacionId { get; set; }
        [NotMapped]
        public string? pais_Nombre { get; set; }
        [NotMapped]
        public string pais_Codigo { get; set; }

        public DateTime? deva_FechaExportacion { get; set; }
        public int? mone_Id { get; set; }
        public string mone_Otra { get; set; }
        public decimal? deva_ConversionDolares { get; set; }
        public string deva_Condiciones { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usua_CreacionNombre { get; set; }
        public DateTime? deva_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usua_ModificacionNombre { get; set; }
        public DateTime? deva_FechaModificacion { get; set; }
        public bool? deva_Estado { get; set; }

        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public DateTime? deva_FechaEliminacion { get; set; }
        public bool deva_Finalizacion { get; set; }

        public virtual tbAduanas deva_AduanaDespacho { get; set; }
        public virtual tbAduanas deva_AduanaIngreso { get; set; }
        public virtual tbLugaresEmbarque emba { get; set; }
        public virtual tbFormas_Envio foen { get; set; }
        public virtual tbFormasdePago fopa { get; set; }
        public virtual tbImportadores impo { get; set; }
        public virtual tbIncoterm inco { get; set; }
        public virtual tbIntermediarios inte { get; set; }
        public virtual tbMonedas mone { get; set; }
        public virtual tbPaises pais_Exportacion { get; set; }
        public virtual tbPaises pais_Entrega { get; set; }
        public virtual tbProveedoresDeclaracion pvde { get; set; }
        public virtual tbRegimenesAduaneros regi { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBaseCalculos> tbBaseCalculos { get; set; }
        public virtual ICollection<tbCondiciones> tbCondiciones { get; set; }
        public virtual ICollection<tbDocumentosPDF> tbDocumentosPDF { get; set; }
        public virtual ICollection<tbDuca> tbDuca { get; set; }
        public virtual ICollection<tbFacturas> tbFacturas { get; set; }

        public virtual ICollection<tbItemsDEVAPorDuca> tbItemsDEVAPorDuca { get; set; }
    }
}
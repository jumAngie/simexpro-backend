using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbUsuarios
    {
        public tbUsuarios()
        {
            Inverseusua_UsuarioCreacionNavigation = new HashSet<tbUsuarios>();
            Inverseusua_UsuarioEliminacionNavigation = new HashSet<tbUsuarios>();
            Inverseusua_UsuarioModificacionNavigation = new HashSet<tbUsuarios>();
            Inverseusua_UsuarioActivacionNavigation = new HashSet<tbUsuarios>();
            tbAduanasusua_UsuarioCreacionNavigation = new HashSet<tbAduanas>();
            tbAduanasusua_UsuarioEliminacionNavigation = new HashSet<tbAduanas>();
            tbAduanasusua_UsuarioModificacionNavigation = new HashSet<tbAduanas>();
            tbAldeasusua_UsuarioCreacionNavigation = new HashSet<tbAldeas>();
            tbAldeasusua_UsuarioEliminacionNavigation = new HashSet<tbAldeas>();
            tbAldeasusua_UsuarioModificacionNavigation = new HashSet<tbAldeas>();
            tbArancelesusua_UsuarioCreacionNavigation = new HashSet<tbAranceles>();
            tbArancelesusua_UsuarioModificacionNavigation = new HashSet<tbAranceles>();
            tbAreausua_UsuarioCreacionNavigation = new HashSet<tbArea>();
            tbAreausua_UsuarioEliminacionNavigation = new HashSet<tbArea>();
            tbAreausua_UsuarioModificacionNavigation = new HashSet<tbArea>();
            tbAsignacionesOrdenDetalleusua_UsuarioCreacionNavigation = new HashSet<tbAsignacionesOrdenDetalle>();
            tbAsignacionesOrdenDetalleusua_UsuarioModificacionNavigation = new HashSet<tbAsignacionesOrdenDetalle>();
            tbAsignacionesOrdenusua_UsuarioCreacionNavigation = new HashSet<tbAsignacionesOrden>();
            tbAsignacionesOrdenusua_UsuarioModificacionNavigation = new HashSet<tbAsignacionesOrden>();
            tbBaseCalculosusua_UsuarioCreacionNavigation = new HashSet<tbBaseCalculos>();
            tbBaseCalculosusua_UsuarioModificacionNavigation = new HashSet<tbBaseCalculos>();
            tbBoletinPagousua_UsuarioCreacionNavigation = new HashSet<tbBoletinPago>();
            tbBoletinPagousua_UsuarioModificacionNavigation = new HashSet<tbBoletinPago>();
            tbBoletinPagoDetallesusua_UsuarioCreacionNavigation = new HashSet<tbBoletinPagoDetalles>();
            tbBoletinPagoDetallesusua_UsuarioModificacionNavigation = new HashSet<tbBoletinPagoDetalles>();
            tbCargosusua_UsuarioCreacionNavigation = new HashSet<tbCargos>();
            tbCargosusua_UsuarioEliminacionNavigation = new HashSet<tbCargos>();
            tbCargosusua_UsuarioModificacionNavigation = new HashSet<tbCargos>();
            tbCategoriausua_UsuarioCreacionNavigation = new HashSet<tbCategoria>();
            tbCategoriausua_UsuarioEliminacionNavigation = new HashSet<tbCategoria>();
            tbCategoriausua_UsuarioModificacionNavigation = new HashSet<tbCategoria>();
            tbCiudadesusua_UsuarioCreacionNavigation = new HashSet<tbCiudades>();
            tbCiudadesusua_UsuarioEliminacionNavigation = new HashSet<tbCiudades>();
            tbCiudadesusua_UsuarioModificacionNavigation = new HashSet<tbCiudades>();
            tbClientesusua_UsuarioCreacionNavigation = new HashSet<tbClientes>();
            tbClientesusua_UsuarioEliminacionNavigation = new HashSet<tbClientes>();
            tbClientesusua_UsuarioModificacionNavigation = new HashSet<tbClientes>();
            tbCodigoImpuestousua_UsuarioCreacionNavigation = new HashSet<tbCodigoImpuesto>();
            tbCodigoImpuestousua_UsuarioEliminacionNavigation = new HashSet<tbCodigoImpuesto>();
            tbCodigoImpuestousua_UsuarioModificacionNavigation = new HashSet<tbCodigoImpuesto>();
            tbColoniasusua_UsuarioCreacionNavigation = new HashSet<tbColonias>();
            tbColoniasusua_UsuarioEliminacionNavigation = new HashSet<tbColonias>();
            tbColoniasusua_UsuarioModificacionNavigation = new HashSet<tbColonias>();
            tbColoresusua_UsuarioCreacionNavigation = new HashSet<tbColores>();
            tbColoresusua_UsuarioEliminacionNavigation = new HashSet<tbColores>();
            tbColoresusua_UsuarioModificacionNavigation = new HashSet<tbColores>();
            tbComercianteIndividualusua_UsuarioCreacionNavigation = new HashSet<tbComercianteIndividual>();
            tbComercianteIndividualusua_UsuarioModificacionNavigation = new HashSet<tbComercianteIndividual>();
            tbConceptoPagousua_UsuarioCreacionNavigation = new HashSet<tbConceptoPago>();
            tbConceptoPagousua_UsuarioModificacionNavigation = new HashSet<tbConceptoPago>();
            tbCondicionesComercialesusua_UsuarioCreacionNavigation = new HashSet<tbCondicionesComerciales>();
            tbCondicionesComercialesusua_UsuarioEliminacionNavigation = new HashSet<tbCondicionesComerciales>();
            tbCondicionesComercialesusua_UsuarioModificacionNavigation = new HashSet<tbCondicionesComerciales>();
            tbCondicionesusua_UsuarioCreacionNavigation = new HashSet<tbCondiciones>();
            tbCondicionesusua_UsuarioModificacionNavigation = new HashSet<tbCondiciones>();
            tbConductorusua_UsuarioCreacionNavigation = new HashSet<tbConductor>();
            tbConductorusua_UsuarioEliminacionNavigation = new HashSet<tbConductor>();
            tbConductorusua_UsuarioModificacionNavigation = new HashSet<tbConductor>();
            tbDeclaraciones_Valorusua_UsuarioCreacionNavigation = new HashSet<tbDeclaraciones_Valor>();
            tbDeclaraciones_Valorusua_UsuarioModificacionNavigation = new HashSet<tbDeclaraciones_Valor>();
            tbDeclarantesusua_UsuarioCreacionNavigation = new HashSet<tbDeclarantes>();
            tbDeclarantesusua_UsuarioEliminacionNavigation = new HashSet<tbDeclarantes>();
            tbDeclarantesusua_UsuarioModificacionNavigation = new HashSet<tbDeclarantes>();
            tbDocumentosContratosusua_UsuarioCreacionNavigation = new HashSet<tbDocumentosContratos>();
            tbDocumentosContratosusua_UsuarioModificacionNavigation = new HashSet<tbDocumentosContratos>();
            tbDocumentosDeSoporteusua_UsuarioCreacionNavigation = new HashSet<tbDocumentosDeSoporte>();
            tbDocumentosDeSoporteusua_UsuarioEliminacionNavigation = new HashSet<tbDocumentosDeSoporte>();
            tbDocumentosDeSoporteusua_UsuarioModificacionNavigation = new HashSet<tbDocumentosDeSoporte>();
            tbDocumentosPDFusua_UsuarioCreacionNavigation = new HashSet<tbDocumentosPDF>();
            tbDocumentosPDFusua_UsuarioEliminacionNavigation = new HashSet<tbDocumentosPDF>();
            tbDocumentosPDFusua_UsuarioModificacionNavigation = new HashSet<tbDocumentosPDF>();
            tbDucausua_UsuarioCreacionNavigation = new HashSet<tbDuca>();
            tbDucausua_UsuarioModificacionNavigation = new HashSet<tbDuca>();
            tbEmpleadosusua_UsuarioCreacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosusua_UsuarioEliminacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosusua_UsuarioModificacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosusua_UsuarioActivacionNavigation = new HashSet<tbEmpleados>();
            tbEstadoBoletinusua_UsuarioCreacionNavigation = new HashSet<tbEstadoBoletin>();
            tbEstadoBoletinusua_UsuarioModificacionNavigation = new HashSet<tbEstadoBoletin>();
            tbEstadoMercanciasusua_UsuarioCreacionNavigation = new HashSet<tbEstadoMercancias>();
            tbEstadoMercanciasusua_UsuarioEliminacionNavigation = new HashSet<tbEstadoMercancias>();
            tbEstadoMercanciasusua_UsuarioModificacionNavigation = new HashSet<tbEstadoMercancias>();
            tbEstadosCivilesusua_UsuarioCreacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstadosCivilesusua_UsuarioEliminacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstadosCivilesusua_UsuarioModificacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstilosusua_UsuarioCreacionNavigation = new HashSet<tbEstilos>();
            tbEstilosusua_UsuarioEliminacionNavigation = new HashSet<tbEstilos>();
            tbEstilosusua_UsuarioModificacionNavigation = new HashSet<tbEstilos>();
            tbFacturasusua_UsuarioCreacionNavigation = new HashSet<tbFacturas>();
            tbFacturasusua_UsuarioModificacionNavigation = new HashSet<tbFacturas>();
            tbFacturasExportacionusua_UsuarioCreacionNavigation = new HashSet<tbFacturasExportacion>();
            tbFacturasExportacionusua_UsuarioModificacionNavigation = new HashSet<tbFacturasExportacion>();
            tbFacturasExportacionDetallesusua_UsuarioCreacionNavigation = new HashSet<tbFacturasExportacionDetalles>();
            tbFacturasExportacionDetallesusua_UsuarioModificacionNavigation = new HashSet<tbFacturasExportacionDetalles>();
            tbFormas_Enviousua_UsuarioCreacionNavigation = new HashSet<tbFormas_Envio>();
            tbFormas_Enviousua_UsuarioEliminacionNavigation = new HashSet<tbFormas_Envio>();
            tbFormas_Enviousua_UsuarioModificacionNavigation = new HashSet<tbFormas_Envio>();
            tbFormasdePagousua_UsuarioCreacionNavigation = new HashSet<tbFormasdePago>();
            tbFormasdePagousua_UsuarioEliminacionNavigation = new HashSet<tbFormasdePago>();
            tbFormasdePagousua_UsuarioModificacionNavigation = new HashSet<tbFormasdePago>();
            tbFuncionesMaquinausua_UsuarioCreacionNavigation = new HashSet<tbFuncionesMaquina>();
            tbFuncionesMaquinausua_UsuarioEliminacionNavigation = new HashSet<tbFuncionesMaquina>();
            tbFuncionesMaquinausua_UsuarioModificacionNavigation = new HashSet<tbFuncionesMaquina>();
            tbImportadoresusua_UsuarioCreacionNavigation = new HashSet<tbImportadores>();
            tbImportadoresusua_UsuarioEliminacionNavigation = new HashSet<tbImportadores>();
            tbImportadoresusua_UsuarioModificacionNavigation = new HashSet<tbImportadores>();
            tbImpuestosPorArancelusua_UsuarioCreacionNavigation = new HashSet<tbImpuestosPorArancel>();
            tbImpuestosPorArancelusua_UsuarioModificacionNavigation = new HashSet<tbImpuestosPorArancel>();
            tbImpuestosusua_UsuarioCreacionNavigation = new HashSet<tbImpuestos>();
            tbImpuestosusua_UsuarioModificacionNavigation = new HashSet<tbImpuestos>();
            tbIncotermusua_UsuarioCreacionNavigation = new HashSet<tbIncoterm>();
            tbIncotermusua_UsuarioEliminacionNavigation = new HashSet<tbIncoterm>();
            tbIncotermusua_UsuarioModificacionNavigation = new HashSet<tbIncoterm>();
            tbIntermediariosusua_UsuarioCreacionNavigation = new HashSet<tbIntermediarios>();
            tbIntermediariosusua_UsuarioEliminacionNavigation = new HashSet<tbIntermediarios>();
            tbIntermediariosusua_UsuarioModificacionNavigation = new HashSet<tbIntermediarios>();
            tbItemsusua_UsuarioCreacionNavigation = new HashSet<tbItems>();
            tbItemsusua_UsuarioModificacionNavigation = new HashSet<tbItems>();
            tbLotesusua_UsuarioCreacionNavigation = new HashSet<tbLotes>();
            tbLotesusua_UsuarioEliminacionNavigation = new HashSet<tbLotes>();
            tbLotesusua_UsuarioModificacionNavigation = new HashSet<tbLotes>();
            tbLugaresEmbarqueusua_UsuarioCreacionNavigation = new HashSet<tbLugaresEmbarque>();
            tbLugaresEmbarqueusua_UsuarioEliminacionNavigation = new HashSet<tbLugaresEmbarque>();
            tbLugaresEmbarqueusua_UsuarioModificacionNavigation = new HashSet<tbLugaresEmbarque>();
            tbMaquinaHistorialusua_UsuarioCreacionNavigation = new HashSet<tbMaquinaHistorial>();
            tbMaquinaHistorialusua_UsuarioEliminacionNavigation = new HashSet<tbMaquinaHistorial>();
            tbMaquinaHistorialusua_UsuarioModificacionNavigation = new HashSet<tbMaquinaHistorial>();
            tbMaquinasusua_UsuarioCreacionNavigation = new HashSet<tbMaquinas>();
            tbMaquinasusua_UsuarioEliminacionNavigation = new HashSet<tbMaquinas>();
            tbMaquinasusua_UsuarioModificacionNavigation = new HashSet<tbMaquinas>();
            tbMarcasMaquinausua_UsuarioCreacionNavigation = new HashSet<tbMarcasMaquina>();
            tbMarcasMaquinausua_UsuarioEliminacionNavigation = new HashSet<tbMarcasMaquina>();
            tbMarcasMaquinausua_UsuarioModificacionNavigation = new HashSet<tbMarcasMaquina>();
            tbMarcasusua_UsuarioCreacionNavigation = new HashSet<tbMarcas>();
            tbMarcasusua_UsuarioEliminacionNavigation = new HashSet<tbMarcas>();
            tbMarcasusua_UsuarioModificacionNavigation = new HashSet<tbMarcas>();
            tbMaterialesBrindarusua_UsuarioCreacionNavigation = new HashSet<tbMaterialesBrindar>();
            tbMaterialesBrindarusua_UsuarioModificacionNavigation = new HashSet<tbMaterialesBrindar>();
            tbMaterialesusua_UsuarioCreacionNavigation = new HashSet<tbMateriales>();
            tbMaterialesusua_UsuarioModificacionNavigation = new HashSet<tbMateriales>();
            tbModelosMaquinausua_UsuarioCreacionNavigation = new HashSet<tbModelosMaquina>();
            tbModelosMaquinausua_UsuarioEliminacionNavigation = new HashSet<tbModelosMaquina>();
            tbModelosMaquinausua_UsuarioModificacionNavigation = new HashSet<tbModelosMaquina>();
            tbModoTransporteusua_UsuarioCreacionNavigation = new HashSet<tbModoTransporte>();
            tbModoTransporteusua_UsuarioEliminacionNavigation = new HashSet<tbModoTransporte>();
            tbModoTransporteusua_UsuarioModificacionNavigation = new HashSet<tbModoTransporte>();
            tbModulosusua_UsuarioCreacionNavigation = new HashSet<tbModulos>();
            tbModulosusua_UsuarioEliminacionNavigation = new HashSet<tbModulos>();
            tbModulosusua_UsuarioModificacionNavigation = new HashSet<tbModulos>();
            tbMonedasusua_UsuarioCreacionNavigation = new HashSet<tbMonedas>();
            tbMonedasusua_UsuarioEliminacionNavigation = new HashSet<tbMonedas>();
            tbMonedasusua_UsuarioModificacionNavigation = new HashSet<tbMonedas>();
            tbNivelesComercialesusua_UsuarioCreacionNavigation = new HashSet<tbNivelesComerciales>();
            tbNivelesComercialesusua_UsuarioEliminacionNavigation = new HashSet<tbNivelesComerciales>();
            tbNivelesComercialesusua_UsuarioModificacionNavigation = new HashSet<tbNivelesComerciales>();
            tbOficinasusua_UsuarioCreacionNavigation = new HashSet<tbOficinas>();
            tbOficinasusua_UsuarioEliminacionNavigation = new HashSet<tbOficinas>();
            tbOficinasusua_UsuarioModificacionNavigation = new HashSet<tbOficinas>();
            tbOficio_Profesionesusua_UsuarioCreacionNavigation = new HashSet<tbOficio_Profesiones>();
            tbOficio_Profesionesusua_UsuarioModificacionNavigation = new HashSet<tbOficio_Profesiones>();
            tbOrde_Ensa_Acab_Etiqusua_UsuarioCreacionNavigation = new HashSet<tbOrde_Ensa_Acab_Etiq>();
            tbOrde_Ensa_Acab_Etiqusua_UsuarioModificacionNavigation = new HashSet<tbOrde_Ensa_Acab_Etiq>();
            tbOrdenCompraDetallesusua_UsuarioCreacionNavigation = new HashSet<tbOrdenCompraDetalles>();
            tbOrdenCompraDetallesusua_UsuarioModificacionNavigation = new HashSet<tbOrdenCompraDetalles>();
            tbOrdenComprausua_UsuarioCreacionNavigation = new HashSet<tbOrdenCompra>();
            tbOrdenComprausua_UsuarioModificacionNavigation = new HashSet<tbOrdenCompra>();
            tbPaisesusua_UsuarioCreacionNavigation = new HashSet<tbPaises>();
            tbPaisesusua_UsuarioEliminacionNavigation = new HashSet<tbPaises>();
            tbPaisesusua_UsuarioModificacionNavigation = new HashSet<tbPaises>();
            tbPantallasusua_UsuarioCreacionNavigation = new HashSet<tbPantallas>();
            tbPantallasusua_UsuarioModificacionNavigation = new HashSet<tbPantallas>();
            tbPedidosOrdenDetalleusua_UsuarioCreacionNavigation = new HashSet<tbPedidosOrdenDetalle>();
            tbPedidosOrdenDetalleusua_UsuarioModificacionNavigation = new HashSet<tbPedidosOrdenDetalle>();
            tbPedidosOrdenusua_UsuarioCreacionNavigation = new HashSet<tbPedidosOrden>();
            tbPedidosOrdenusua_UsuarioModificacionNavigation = new HashSet<tbPedidosOrden>();
            tbPedidosProduccionDetallesusua_UsuarioCreacionNavigation = new HashSet<tbPedidosProduccionDetalles>();
            tbPedidosProduccionDetallesusua_UsuarioModificacionNavigation = new HashSet<tbPedidosProduccionDetalles>();
            tbPedidosProduccionusua_UsuarioCreacionNavigation = new HashSet<tbPedidosProduccion>();
            tbPedidosProduccionusua_UsuarioModificacionNavigation = new HashSet<tbPedidosProduccion>();
            tbPersonaJuridicausua_UsuarioCreacionNavigation = new HashSet<tbPersonaJuridica>();
            tbPersonaJuridicausua_UsuarioModificacionNavigation = new HashSet<tbPersonaJuridica>();
            tbPersonaNaturalusua_UsuarioCreacionNavigation = new HashSet<tbPersonaNatural>();
            tbPersonaNaturalusua_UsuarioModificacionNavigation = new HashSet<tbPersonaNatural>();
            tbPersonasusua_UsuarioCreacionNavigation = new HashSet<tbPersonas>();
            tbPersonasusua_UsuarioModificacionNavigation = new HashSet<tbPersonas>();
            tbPODetallePorPedidoOrdenDetalleusua_UsuarioCreacionNavigation = new HashSet<tbPODetallePorPedidoOrdenDetalle>();
            tbPODetallePorPedidoOrdenDetalleusua_UsuarioModificacionNavigation = new HashSet<tbPODetallePorPedidoOrdenDetalle>();
            tbProcesoPorOrdenCompraDetalleusua_UsuarioCreacionNavigation = new HashSet<tbProcesoPorOrdenCompraDetalle>();
            tbProcesoPorOrdenCompraDetalleusua_UsuarioModificacionNavigation = new HashSet<tbProcesoPorOrdenCompraDetalle>();
            tbProcesosusua_UsuarioCreacionNavigation = new HashSet<tbProcesos>();
            tbProcesosusua_UsuarioEliminacionNavigation = new HashSet<tbProcesos>();
            tbProcesosusua_UsuarioModificacionNavigation = new HashSet<tbProcesos>();
            tbProveedoresDeclaracionusua_UsuarioCreacionNavigation = new HashSet<tbProveedoresDeclaracion>();
            tbProveedoresDeclaracionusua_UsuarioEliminacionNavigation = new HashSet<tbProveedoresDeclaracion>();
            tbProveedoresDeclaracionusua_UsuarioModificacionNavigation = new HashSet<tbProveedoresDeclaracion>();
            tbProveedoresusua_UsuarioCreacionNavigation = new HashSet<tbProveedores>();
            tbProveedoresusua_UsuarioEliminacionNavigation = new HashSet<tbProveedores>();
            tbProveedoresusua_UsuarioModificacionNavigation = new HashSet<tbProveedores>();
            tbProvinciasusua_UsuarioCreacionNavigation = new HashSet<tbProvincias>();
            tbProvinciasusua_UsuarioEliminacionNavigation = new HashSet<tbProvincias>();
            tbProvinciasusua_UsuarioModificacionNavigation = new HashSet<tbProvincias>();
            tbReporteModuloDiaDetalleusua_UsuarioCreacionNavigation = new HashSet<tbReporteModuloDiaDetalle>();
            tbReporteModuloDiaDetalleusua_UsuarioModificacionNavigation = new HashSet<tbReporteModuloDiaDetalle>();
            tbReporteModuloDiausua_UsuarioCreacionNavigation = new HashSet<tbReporteModuloDia>();
            tbReporteModuloDiausua_UsuarioModificacionNavigation = new HashSet<tbReporteModuloDia>();
            tbRevisionDeCalidadusua_UsuarioCreacionNavigation = new HashSet<tbRevisionDeCalidad>();
            tbRevisionDeCalidadusua_UsuarioModificacionNavigation = new HashSet<tbRevisionDeCalidad>();
            tbRolesXPantallasusua_UsuarioCreacionNavigation = new HashSet<tbRolesXPantallas>();
            tbRolesXPantallasusua_UsuarioEliminacionNavigation = new HashSet<tbRolesXPantallas>();
            tbRolesXPantallasusua_UsuarioModificacionNavigation = new HashSet<tbRolesXPantallas>();
            tbRolesusua_UsuarioCreacionNavigation = new HashSet<tbRoles>();
            tbRolesusua_UsuarioEliminacionNavigation = new HashSet<tbRoles>();
            tbRolesusua_UsuarioModificacionNavigation = new HashSet<tbRoles>();
            tbSubcategoriausua_UsuarioCreacionNavigation = new HashSet<tbSubcategoria>();
            tbSubcategoriausua_UsuarioEliminacionNavigation = new HashSet<tbSubcategoria>();
            tbTallasusua_UsuarioCreacionNavigation = new HashSet<tbTallas>();
            tbTallasusua_UsuarioEliminacionNavigation = new HashSet<tbTallas>();
            tbTallasusua_UsuarioModificacionNavigation = new HashSet<tbTallas>();
            tbTipoDocumentousua_UsuarioCreacionNavigation = new HashSet<tbTipoDocumento>();
            tbTipoDocumentousua_UsuarioEliminacionNavigation = new HashSet<tbTipoDocumento>();
            tbTipoDocumentousua_UsuarioModificacionNavigation = new HashSet<tbTipoDocumento>();
            tbTipoEmbalajeusua_UsuarioCreacionNavigation = new HashSet<tbTipoEmbalaje>();
            tbTipoEmbalajeusua_UsuarioEliminacionNavigation = new HashSet<tbTipoEmbalaje>();
            tbTipoEmbalajeusua_UsuarioModificacionNavigation = new HashSet<tbTipoEmbalaje>();
            tbTipoIntermediariousua_UsuarioCreacionNavigation = new HashSet<tbTipoIntermediario>();
            tbTipoIntermediariousua_UsuarioEliminacionNavigation = new HashSet<tbTipoIntermediario>();
            tbTipoIntermediariousua_UsuarioModificacionNavigation = new HashSet<tbTipoIntermediario>();
            tbTipoLiquidacionusua_UsuarioCreacionNavigation = new HashSet<tbTipoLiquidacion>();
            tbTipoLiquidacionusua_UsuarioModificacionNavigation = new HashSet<tbTipoLiquidacion>();
            tbTiposIdentificacionusua_UsuarioCreacionNavigation = new HashSet<tbTiposIdentificacion>();
            tbTiposIdentificacionusua_UsuarioEliminacionNavigation = new HashSet<tbTiposIdentificacion>();
            tbTiposIdentificacionusua_UsuarioModificacionNavigation = new HashSet<tbTiposIdentificacion>();
            tbTransporteusua_UsuarioCreacioNavigation = new HashSet<tbTransporte>();
            tbTransporteusua_UsuarioEliminacionNavigation = new HashSet<tbTransporte>();
            tbTransporteusua_UsuarioModificacionNavigation = new HashSet<tbTransporte>();
            tbUnidadMedidasusua_UsuarioCreacionNavigation = new HashSet<tbUnidadMedidas>();
            tbUnidadMedidasusua_UsuarioEliminacionNavigation = new HashSet<tbUnidadMedidas>();
            tbUnidadMedidasusua_UsuarioModificacionNavigation = new HashSet<tbUnidadMedidas>();
        }

        public int usua_Id { get; set; }
        public string usua_Nombre { get; set; }
        public string usua_Contrasenia { get; set; }

        [NotMapped]
        public string empl_CorreoElectronico { get; set; }

        [NotMapped]
        public string emplNombreCompleto { get; set; }

        public int empl_Id { get; set; }

        [NotMapped]
        public bool usua_esAduana { get; set; }
        public string usua_Image { get; set; }
        public int role_Id { get; set; }

        [NotMapped]
        public string role_Descripcion { get; set; }
        public bool usua_EsAdmin { get; set; }
        public bool empl_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime usua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? usua_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }
        public DateTime? usua_FechaEliminacion { get; set; }
        public bool? usua_Estado { get; set; }
        public int? usua_UsuarioActivacion { get; set; }
        [NotMapped]
        public string usuarioActivacionNombre { get; set; }
        public DateTime? usua_FechaActivacion { get; set; }



        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioActivacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> Inverseusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> Inverseusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> Inverseusua_UsuarioActivacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> Inverseusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAduanas> tbAduanasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAduanas> tbAduanasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbAduanas> tbAduanasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAldeas> tbAldeasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAldeas> tbAldeasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbAldeas> tbAldeasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAranceles> tbArancelesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAranceles> tbArancelesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbArea> tbAreausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbArea> tbAreausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbArea> tbAreausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrdenDetalle> tbAsignacionesOrdenDetalleusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrdenDetalle> tbAsignacionesOrdenDetalleusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrden> tbAsignacionesOrdenusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrden> tbAsignacionesOrdenusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBaseCalculos> tbBaseCalculosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbBaseCalculos> tbBaseCalculosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPago> tbBoletinPagousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPago> tbBoletinPagousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPagoDetalles> tbBoletinPagoDetallesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPagoDetalles> tbBoletinPagoDetallesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCategoria> tbCategoriausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCategoria> tbCategoriausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbCategoria> tbCategoriausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCiudades> tbCiudadesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCiudades> tbCiudadesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbCiudades> tbCiudadesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCodigoImpuesto> tbCodigoImpuestousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCodigoImpuesto> tbCodigoImpuestousua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbCodigoImpuesto> tbCodigoImpuestousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbColonias> tbColoniasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbColonias> tbColoniasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbColonias> tbColoniasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbColores> tbColoresusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbColores> tbColoresusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbColores> tbColoresusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbComercianteIndividual> tbComercianteIndividualusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbComercianteIndividual> tbComercianteIndividualusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbConceptoPago> tbConceptoPagousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbConceptoPago> tbConceptoPagousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCondicionesComerciales> tbCondicionesComercialesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCondicionesComerciales> tbCondicionesComercialesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbCondicionesComerciales> tbCondicionesComercialesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCondiciones> tbCondicionesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCondiciones> tbCondicionesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbConductor> tbConductorusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbConductor> tbConductorusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbConductor> tbConductorusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valorusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valorusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclarantes> tbDeclarantesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDeclarantes> tbDeclarantesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbDeclarantes> tbDeclarantesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosDeSoporte> tbDocumentosDeSoporteusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosDeSoporte> tbDocumentosDeSoporteusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosDeSoporte> tbDocumentosDeSoporteusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosOrdenCompraDetalles> tbDocumentosOrdenCompraDetallesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosOrdenCompraDetalles> tbDocumentosOrdenCompraDetallesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosPDF> tbDocumentosPDFusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosPDF> tbDocumentosPDFusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosPDF> tbDocumentosPDFusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosusua_UsuarioActivacionNavigation { get; set; }
        public virtual ICollection<tbEstadoBoletin> tbEstadoBoletinusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadoBoletin> tbEstadoBoletinusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEstadoMercancias> tbEstadoMercanciasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadoMercancias> tbEstadoMercanciasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbEstadoMercancias> tbEstadoMercanciasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEstilos> tbEstilosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstilos> tbEstilosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbEstilos> tbEstilosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturas> tbFacturasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFacturas> tbFacturasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturasExportacion> tbFacturasExportacionusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFacturasExportacion> tbFacturasExportacionusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturasExportacionDetalles> tbFacturasExportacionDetallesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFacturasExportacionDetalles> tbFacturasExportacionDetallesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFormas_Envio> tbFormas_Enviousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFormas_Envio> tbFormas_Enviousua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbFormas_Envio> tbFormas_Enviousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFormasdePago> tbFormasdePagousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFormasdePago> tbFormasdePagousua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbFormasdePago> tbFormasdePagousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFuncionesMaquina> tbFuncionesMaquinausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFuncionesMaquina> tbFuncionesMaquinausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbFuncionesMaquina> tbFuncionesMaquinausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbImportadores> tbImportadoresusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbImportadores> tbImportadoresusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbImportadores> tbImportadoresusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbImpuestosPorArancel> tbImpuestosPorArancelusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbImpuestosPorArancel> tbImpuestosPorArancelusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbImpuestos> tbImpuestosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbImpuestos> tbImpuestosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbIncoterm> tbIncotermusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbIncoterm> tbIncotermusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbIncoterm> tbIncotermusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbIntermediarios> tbIntermediariosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbIntermediarios> tbIntermediariosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbIntermediarios> tbIntermediariosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbItems> tbItemsusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbItems> tbItemsusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbLotes> tbLotesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbLotes> tbLotesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbLotes> tbLotesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbLugaresEmbarque> tbLugaresEmbarqueusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbLugaresEmbarque> tbLugaresEmbarqueusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbLugaresEmbarque> tbLugaresEmbarqueusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMaquinaHistorial> tbMaquinaHistorialusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMaquinaHistorial> tbMaquinaHistorialusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbMaquinaHistorial> tbMaquinaHistorialusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMaquinas> tbMaquinasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMaquinas> tbMaquinasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbMaquinas> tbMaquinasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMarcasMaquina> tbMarcasMaquinausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMarcasMaquina> tbMarcasMaquinausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbMarcasMaquina> tbMarcasMaquinausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMarcas> tbMarcasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMarcas> tbMarcasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbMarcas> tbMarcasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMaterialesBrindar> tbMaterialesBrindarusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMaterialesBrindar> tbMaterialesBrindarusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMateriales> tbMaterialesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMateriales> tbMaterialesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbModelosMaquina> tbModelosMaquinausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbModelosMaquina> tbModelosMaquinausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbModelosMaquina> tbModelosMaquinausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbModoTransporte> tbModoTransporteusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbModoTransporte> tbModoTransporteusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbModoTransporte> tbModoTransporteusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbModulos> tbModulosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbModulos> tbModulosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbModulos> tbModulosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMonedas> tbMonedasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMonedas> tbMonedasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbMonedas> tbMonedasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbNivelesComerciales> tbNivelesComercialesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbNivelesComerciales> tbNivelesComercialesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbNivelesComerciales> tbNivelesComercialesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOficinas> tbOficinasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbOficinas> tbOficinasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbOficinas> tbOficinasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOficio_Profesiones> tbOficio_Profesionesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbOficio_Profesiones> tbOficio_Profesionesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiqusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiqusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetallesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetallesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompra> tbOrdenComprausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompra> tbOrdenComprausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPaises> tbPaisesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPaises> tbPaisesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbPaises> tbPaisesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrdenDetalle> tbPedidosOrdenDetalleusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrdenDetalle> tbPedidosOrdenDetalleusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrden> tbPedidosOrdenusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrden> tbPedidosOrdenusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosProduccionDetalles> tbPedidosProduccionDetallesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPedidosProduccionDetalles> tbPedidosProduccionDetallesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosProduccion> tbPedidosProduccionusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPedidosProduccion> tbPedidosProduccionusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridicausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridicausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonaNatural> tbPersonaNaturalusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPersonaNatural> tbPersonaNaturalusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPODetallePorPedidoOrdenDetalle> tbPODetallePorPedidoOrdenDetalleusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPODetallePorPedidoOrdenDetalle> tbPODetallePorPedidoOrdenDetalleusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProcesos> tbProcesosusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalleusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalleusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProcesos> tbProcesosusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbProcesos> tbProcesosusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProveedoresDeclaracion> tbProveedoresDeclaracionusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbProveedoresDeclaracion> tbProveedoresDeclaracionusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbProveedoresDeclaracion> tbProveedoresDeclaracionusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProveedores> tbProveedoresusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbProveedores> tbProveedoresusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbProveedores> tbProveedoresusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProvincias> tbProvinciasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbProvincias> tbProvinciasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbProvincias> tbProvinciasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbReporteModuloDiaDetalle> tbReporteModuloDiaDetalleusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbReporteModuloDiaDetalle> tbReporteModuloDiaDetalleusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbReporteModuloDia> tbReporteModuloDiausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbReporteModuloDia> tbReporteModuloDiausua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRevisionDeCalidad> tbRevisionDeCalidadusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbRevisionDeCalidad> tbRevisionDeCalidadusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbSubcategoria> tbSubcategoriausua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbSubcategoria> tbSubcategoriausua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTallas> tbTallasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTallas> tbTallasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTallas> tbTallasusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTipoDocumento> tbTipoDocumentousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTipoDocumento> tbTipoDocumentousua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTipoDocumento> tbTipoDocumentousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTipoEmbalaje> tbTipoEmbalajeusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTipoEmbalaje> tbTipoEmbalajeusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTipoEmbalaje> tbTipoEmbalajeusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTipoIntermediario> tbTipoIntermediariousua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTipoIntermediario> tbTipoIntermediariousua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTipoIntermediario> tbTipoIntermediariousua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTipoLiquidacion> tbTipoLiquidacionusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTipoLiquidacion> tbTipoLiquidacionusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTiposIdentificacion> tbTiposIdentificacionusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTiposIdentificacion> tbTiposIdentificacionusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTiposIdentificacion> tbTiposIdentificacionusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTransporte> tbTransporteusua_UsuarioCreacioNavigation { get; set; }
        public virtual ICollection<tbTransporte> tbTransporteusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbTransporte> tbTransporteusua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbUnidadMedidas> tbUnidadMedidasusua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbUnidadMedidas> tbUnidadMedidasusua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbUnidadMedidas> tbUnidadMedidasusua_UsuarioModificacionNavigation { get; set; }


        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalle_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalle_UsuarioCreacionNavigation { get; set; }
    }
}
using AutoMapper;
using SIMEXPRO.API.Models;
using SIMEXPRO.API.Models.ModelsAcceso;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.API.Models.ModelsProduccion;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Extentions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            #region Generales
            CreateMap<AldeasViewModel, tbAldeas>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<CiudadesViewModel, tbCiudades>().ReverseMap();
            CreateMap<ColoniasViewModel, tbColonias>().ReverseMap();
            CreateMap<EmpleadosViewModel, tbEmpleados>().ReverseMap();
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<Formas_EnvioViewModel, tbFormas_Envio>().ReverseMap();
            CreateMap<MonedasViewModel, tbMonedas>().ReverseMap();
            CreateMap<OficinasViewModel, tbOficinas>().ReverseMap();
            CreateMap<Oficio_ProfesionesViewModel, tbOficio_Profesiones>().ReverseMap();
            CreateMap<PaisesViewModel, tbPaises>().ReverseMap();
            CreateMap<ProveedoresViewModel, tbProveedores>().ReverseMap();
            CreateMap<ProvinciasViewModel, tbProvincias>().ReverseMap();
            CreateMap<UnidadMedidaViewModel, tbUnidadMedidas>().ReverseMap();
            #endregion

            #region Aduana
            CreateMap<DucaViewModel, tbDuca>().ReverseMap();
            CreateMap<AduanasViewModel, tbAduanas>().ReverseMap();
            CreateMap<Declaraciones_ValorViewModel, tbDeclaraciones_Valor>().ReverseMap();
            CreateMap<ArancelesViewModel, tbAranceles>().ReverseMap();
            CreateMap<BaseCalculosViewModel, tbBaseCalculos>().ReverseMap();
            CreateMap<BoletinPagoViewModel, tbBoletinPago>().ReverseMap();
            CreateMap<BoletinPagoDetallesViewModel, tbBoletinPagoDetalles>().ReverseMap();
            CreateMap<CodigoImpuestoViewModel, tbCodigoImpuesto>().ReverseMap();
            CreateMap<CondicionesComercialesViewModel, tbCondicionesComerciales>().ReverseMap();
            CreateMap<ImportadoresViewModel, tbImportadores>();
            CreateMap<ImpuestosViewModel, tbImpuestos>().ReverseMap();
            CreateMap<TransportesViewModel, tbTransporte>().ReverseMap();
            CreateMap<TiposIdentificacionViewModel, tbTiposIdentificacion>().ReverseMap();
            CreateMap<TipoLiquidacionViewModel, tbTipoLiquidacion>().ReverseMap();
            CreateMap<TipoIntermediarioViewModel, tbTipoIntermediario>().ReverseMap();
            CreateMap<TipoDocumentoViewModel, tbTipoDocumento>().ReverseMap();
            CreateMap<ComercianteIndividual, tbComercianteIndividual>().ReverseMap();
            CreateMap<PersonasViewModel, tbPersonas>().ReverseMap();
            CreateMap<PersonaNaturalViewModel, tbPersonaNatural>().ReverseMap();
            CreateMap<ProveedoresDeclaracionViewModel, tbProveedoresDeclaracion>().ReverseMap();
            CreateMap<ConceptoPagoViewModel, tbConceptoPago>().ReverseMap();
            CreateMap<EstadoBoletinViewModel, tbEstadoBoletin>().ReverseMap();
            CreateMap<FormasDePagoViewModel, tbFormasdePago>().ReverseMap();
            CreateMap<ItemsViewModel, tbItems>().ReverseMap();
            CreateMap<IntermediarioViewModel, tbIntermediarios>().ReverseMap();
            CreateMap<IncotermViewModel, tbIncoterm>().ReverseMap();
            CreateMap<LiquidacionGeneralViewModel, tbLiquidacionGeneral>().ReverseMap();
            CreateMap<LiquidacionPorLineaViewModel, tbLiquidacionPorLinea>().ReverseMap();
            CreateMap<LugaresEmbarqueViewModel, tbLugaresEmbarque>().ReverseMap();
            CreateMap<MarcasViewModel, tbMarcas>().ReverseMap();
            CreateMap<ModoTransporteViewModel, tbModoTransporte>().ReverseMap();
            CreateMap<NivelesComercialesViewModel, tbNivelesComerciales>().ReverseMap();
            CreateMap<PersonaJuridicaViewModel, tbPersonaJuridica>().ReverseMap();
            CreateMap<DocumentosPDFViewModel,tbDocumentosPDF>().ReverseMap();
            CreateMap<DocumentosContratosViewModel, tbDocumentosContratos>().ReverseMap();
            CreateMap<DocumentosDeSoporteViewModel, tbDocumentosDeSoporte>().ReverseMap();
            CreateMap<FacturasViewModel, tbFacturas>().ReverseMap();
            CreateMap<DocumentosContratosViewModel, tbDocumentosContratos>().ReverseMap();
            CreateMap<EstadoMercanciasViewModel, tbEstadoMercancias>().ReverseMap();
            CreateMap<DeclarantesViewModel, tbDeclarantes>().ReverseMap();
            CreateMap<DocumentosSancionesViewModel, tbDocumentosSanciones>().ReverseMap();
            CreateMap<tbDuca, DucaViewModel>().ReverseMap();
            CreateMap<tbCondiciones, CondicionesViewModel>().ReverseMap();
            CreateMap<RegimenesAduanerosViewModel, tbRegimenesAduaneros>().ReverseMap();
            CreateMap<ItemsDEVAxDUCAViewModel, tbItemsDEVAPorDuca>().ReverseMap();
            CreateMap<TratadosLibreComercioViewModel, tbTratadosLibreComercio>().ReverseMap();
            CreateMap<EcotasaViewModel, tbEcotasa>().ReverseMap();
            CreateMap<ImpuestosSelectivoConsumoCondicionesVehiculosViewModel, tbImpuestoSelectivoConsumoCondicionesVehiculos>().ReverseMap();
            CreateMap<ArancelesPorTratadoViewModel, tbArancelesPorTratados>().ReverseMap();
            #endregion

            #region Producción

            CreateMap<AreasViewModel, tbArea>().ReverseMap();
            CreateMap<AsignacionesOrdenViewModel, tbAsignacionesOrden>().ReverseMap();
            CreateMap<AsignacionesOrdenDetalleViewModel, tbAsignacionesOrdenDetalle>().ReverseMap();
            CreateMap<CategoriaViewModel, tbCategoria>().ReverseMap();
            CreateMap<ClientesViewModel, tbClientes>().ReverseMap();
            CreateMap<ColoresViewModel, tbColores>().ReverseMap();

            CreateMap<ProcesosViewModel, tbProcesos>().ReverseMap();
            CreateMap<ReporteModuloDiaViewModel, tbReporteModuloDia>().ReverseMap();

            CreateMap<ReporteModuloDiaDetalleViewModel, tbReporteModuloDiaDetalle>().ReverseMap();
            CreateMap<RevisionDeCalidadViewModel, tbRevisionDeCalidad>().ReverseMap();
            CreateMap<SubCategoriaViewModel, tbSubcategoria>().ReverseMap();
            CreateMap<EstilosViewModel, tbEstilos>().ReverseMap();
            CreateMap<FuncionesMaquinaViewModel, tbFuncionesMaquina>().ReverseMap();
            CreateMap<TallasViewModel, tbTallas>().ReverseMap();
            CreateMap<TipoEmbalajeViewModel, tbTipoEmbalaje>().ReverseMap();
            CreateMap<LotesViewModel, tbLotes>().ReverseMap();
            CreateMap<MaquinaHistorialViewModel, tbMaquinaHistorial>().ReverseMap();
            CreateMap<MaquinasViewModel, tbMaquinas>().ReverseMap();
            CreateMap<MarcasMaquinaViewModel, tbMarcasMaquina>().ReverseMap();
            CreateMap<MaterialesViewModel, tbMateriales>().ReverseMap();
            CreateMap<MaterialesBrindarViewModel, tbMaterialesBrindar>().ReverseMap();
            CreateMap<ModelosMaquinaViewModel, tbModelosMaquina>().ReverseMap();


            CreateMap<tbModulos, ModulosViewModel>().ReverseMap();
            CreateMap<tbDocumentosOrdenCompraDetalles, DocumentosOrdenCompraDetallesViewModel>().ReverseMap();
            CreateMap<tbOrde_Ensa_Acab_Etiq, OrdeEnsaAcabEtiqViewModel>().ReverseMap();
            CreateMap<tbOrdenCompra, OrdenCompraViewModel>().ReverseMap();
            CreateMap<tbOrdenCompraDetalles, OrdenCompraDetalleViewModel>().ReverseMap();
            CreateMap<tbPedidosOrden, PedidosOrdenViewModel>().ReverseMap();
            CreateMap<tbPedidosOrdenDetalle, PedidosOrdenDetalleViewModel>().ReverseMap();
            CreateMap<tbPedidosProduccion, PedidosProduccionViewModel>().ReverseMap();
            CreateMap<tbPedidosProduccionDetalles, PedidosProduccionDetalleViewModel>().ReverseMap();
            CreateMap<tbPODetallePorPedidoOrdenDetalle, PODetallePorPedidoOrdenDetalleViewModel>().ReverseMap();
            CreateMap<tbProcesoPorOrdenCompraDetalle, ProcesoPorOrdenCompraDetalleViewModel>().ReverseMap();

            CreateMap<tbFacturasExportacion, FacturasExportacionViewModel>().ReverseMap();
            CreateMap<tbFacturasExportacionDetalles, FacturaExportacionDetallesViewModel>().ReverseMap();
            CreateMap<tbImpuestosProd, ImpuestoProdViewModel>().ReverseMap();
            #endregion

            #region Acceso
            CreateMap<UsuariosViewModel, tbUsuarios>().ReverseMap();
            CreateMap<PantallasViewModel, tbPantallas>().ReverseMap();
            CreateMap<RolesViewModel, tbRoles>().ReverseMap();
            CreateMap<RolesPorPantallasViewModel, tbRolesXPantallas>().ReverseMap();

            #endregion

            #region Graficas
            CreateMap<GraficasViewModel, tbGraficas>().ReverseMap();
            #endregion

            #region Reportes
            CreateMap<ReportesViewModel, tbReportes>().ReverseMap();
            #endregion
        }
    }
}

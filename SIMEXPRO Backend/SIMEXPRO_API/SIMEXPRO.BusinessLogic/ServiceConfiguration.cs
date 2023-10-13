
using Microsoft.Extensions.DependencyInjection;
using SIMEXPRO.BussinessLogic.Services.AccesoServices;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using SIMEXPRO.BussinessLogic.Services.GeneralServices;
using SIMEXPRO.BussinessLogic.Services.ProduccionServices;
using SIMEXPRO.DataAccess.Repositories.Acce;
using SIMEXPRO.DataAccess.Repositories.Adua;
using SIMEXPRO.DataAccess.Repositories.Gral;
using SIMEXPRO.DataAccess.Repositories.Prod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.BussinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection services, string connection)
        {
            SIMEXPRO.DataAccess.SIMEXPRO.BuildConnectionString(connection);

            //Acceso
            services.AddScoped<PantallasRepository>();
            services.AddScoped<RolesPorPantallaRepository>();
            services.AddScoped<RolesRepository>();
            services.AddScoped<UsuariosHistorialRepository>();
            services.AddScoped<UsuariosRepository>();

            //Aduanas
            services.AddScoped<AduanasRepository>();
            services.AddScoped<ArancelesRepository>();
            services.AddScoped<BaseCalculosRepository>();
            services.AddScoped<BoletinPagoRepository>();
            services.AddScoped<BoletinPagoDetallesRepository>();
            services.AddScoped<CodigoImpuestoRepository>();
            services.AddScoped<ComercianteIndividualRepository>();
            services.AddScoped<ConceptoPagoRepository>();
            services.AddScoped<CondicionesComercialesRepository>();
            services.AddScoped<CondicionesRepository>();
            services.AddScoped<Declaraciones_ValorHistorialRepository>();
            services.AddScoped<Declaraciones_ValorRepository>();
            services.AddScoped<DocumentosContratosRepository>();
            services.AddScoped<DocumentosdeSoporteRepository>();
            services.AddScoped<DocumentosPDFRepository>();
            services.AddScoped<DocumentosSancionesRepository>();
            services.AddScoped<DucaRepository>();
            services.AddScoped<EcotasaRepository>();
            services.AddScoped<EstadoBoletinRepository>();
            services.AddScoped<EstadoMercanciasRepository>();
            services.AddScoped<FacturasRepository>();
            services.AddScoped<FormasdePagoRepository>();
            services.AddScoped<ImpuestosporAracelRepository>();
            services.AddScoped<ImpuestoSelectivoConsumoCondicionesVehiculosRepository>();
            services.AddScoped<ImpuestosRepository>();
            services.AddScoped<IncotermRepository>();
            services.AddScoped<IntermediarioRepository>();
            services.AddScoped<ItemsRepository>();
            services.AddScoped<LiquidacionGeneralRepository>();
            services.AddScoped<LiquidacionPorLineaRepository>();
            services.AddScoped<LugaresEmbarqueRepository>();
            services.AddScoped<MarcasRepository>();
            services.AddScoped<ModoTransporteRepository>();
            services.AddScoped<NivelesComercialesRepository>();
            services.AddScoped<PersonaJuridicaRepository>();
            services.AddScoped<PersonaNaturalRepository>();
            services.AddScoped<PersonasRepository>();
            services.AddScoped<TipoDocumentoRepository>();
            services.AddScoped<TipoIntermediarioRepository>();
            services.AddScoped<TipoLiquidacionRepository>();
            services.AddScoped<TiposIdentificacionRepository>();
            services.AddScoped<TransporteRepository>();
            services.AddScoped<AduanaGraficasRepository>();
            services.AddScoped<ReportesRepository>();
            services.AddScoped<RegimenesAduanerosRepository>();
            services.AddScoped<ImportadoresRepository>();
            services.AddScoped<ItemsDEVAporDUCARepository>();
            services.AddScoped<TratadosLibreComercioRepository>();
            services.AddScoped<PaisesEstanTratadosConHondurasRepository>();

            //General
            services.AddScoped<AldeasRepository>();
            services.AddScoped<CargosRepository>();
            services.AddScoped<CiudadesRepository>();
            services.AddScoped<ColoniasRepository>();
            services.AddScoped<EmpleadosRepository>();
            services.AddScoped<EstadosCivilesRepository>();
            services.AddScoped<FormasEnvioRepository>();
            services.AddScoped<MonedasRepository>();
            services.AddScoped<OficinasRepository>();
            services.AddScoped<OficioProfesionesRepository>();
            services.AddScoped<PaisesRepository>();
            services.AddScoped<ProveedoresRepository>();
            services.AddScoped<ProvinciasRepository>();
            services.AddScoped<UnidadMedidasRepository>();


            //Produccion
            services.AddScoped<AreasRepository>();
            services.AddScoped<AsignacionesOrdenDetalleRepository>();
            services.AddScoped<AsignacionesOrdenRepository>();
            services.AddScoped<CategoriasRepository>();
            services.AddScoped<ClientesRepository>();
            services.AddScoped<ColoresRepository>();
            services.AddScoped<EstilosRepository>();
            services.AddScoped<FuncionesMaquinaRepository>();
            services.AddScoped<LotesRepository>();
            services.AddScoped<MaquinaHistorialRepository>();
            services.AddScoped<MaquinasRepository>();
            services.AddScoped<MarcasMaquinaRepository>();
            services.AddScoped<MaterialesBrindarRepository>();
            services.AddScoped<MaterialesRepository>();
            services.AddScoped<ModelosMaquinaRepository>();
            services.AddScoped<ModulosRepository>();
            services.AddScoped<Orde_Ensa_Acab_EtiqRepository>();
            services.AddScoped<OrdenCompraDetallesRepository>();
            services.AddScoped<OrdenCompraRepository>();
            services.AddScoped<PedidosOrdenDetallesRepository>();
            services.AddScoped<PedidosOrdenRepository>();
            services.AddScoped<PedidosProduccionDetallesRepository>();
            services.AddScoped<PedidosProduccionRepository>();
            services.AddScoped<PODetallePorPedidoOrdenDetalleRepository>();
            services.AddScoped<ProcesosRepository>();
            services.AddScoped<ReporteModuloDiaDetalleRepository>();
            services.AddScoped<ReporteModuloDiaRepository>();
            services.AddScoped<RevisionDeCalidadRepository>();
            services.AddScoped<SubCategoriasRepository>();
            services.AddScoped<TallasRepository>();
            services.AddScoped<TipoEmbalajeRepository>();
            services.AddScoped<DocumentosOrdenCompraDetallesRepository>();
            services.AddScoped<GraficasRepository>();
            services.AddScoped<ProcesoPorOrdenCompraDetalleRepository>();
            services.AddScoped<FacturasExportacionRepository>();
            services.AddScoped<FacturasExportacionDetallesRepository>();
            services.AddScoped<ImpuestoProdRepository>();

        }


        public static void BussinessLogic(this IServiceCollection services)
        {
            services.AddScoped<GeneralServices>();
            services.AddScoped<AccesoServices>();
            services.AddScoped<ProduccionServices>();
            services.AddScoped<AduanaServices>();

        }
    }
}


using SIMEXPRO.DataAccess.Repositories.Prod;
using SIMEXPRO.Entities.Entities;
using System;

namespace SIMEXPRO.BussinessLogic.Services.ProduccionServices
{
    public class ProduccionServices
    {
        private readonly AreasRepository _areasRepository;
        private readonly AsignacionesOrdenDetalleRepository _asignacionesOrdenDetalleRepository;
        private readonly AsignacionesOrdenRepository _asignacionesOrdenRepository;
        private readonly CategoriasRepository _categoriasRepository;
        private readonly ClientesRepository _clientesRepository;
        private readonly ColoresRepository _coloresRepository;
        private readonly EstilosRepository _estilosRepository;
        private readonly FuncionesMaquinaRepository _funcionesMaquinaRepository;
        private readonly LotesRepository _lotesRepository;
        private readonly MaquinaHistorialRepository _maquinaHistorialRepository;
        private readonly MaquinasRepository _maquinasRepository;
        private readonly MarcasMaquinaRepository _marcasMaquinaRepository;
        private readonly MaterialesBrindarRepository _materialesBrindarRepository;
        private readonly MaterialesRepository _materialesRepository;
        private readonly ModelosMaquinaRepository _modelosMaquinaRepository;
        private readonly ModulosRepository _modulosRepository;
        private readonly Orde_Ensa_Acab_EtiqRepository _orde_Ensa_Acab_EtiqRepository;
        private readonly OrdenCompraDetallesRepository _ordenCompraDetallesRepository;
        private readonly OrdenCompraRepository _ordenCompraRepository;
        private readonly PedidosOrdenDetallesRepository _pedidosOrdenDetallesRepository;
        private readonly PedidosOrdenRepository _pedidosOrdenRepository;
        private readonly PedidosProduccionDetallesRepository _pedidosProduccionDetallesRepository;
        private readonly PedidosProduccionRepository _pedidosProduccionRepository;
        private readonly PODetallePorPedidoOrdenDetalleRepository _PODetallePorPedidoOrdenDetalleRepository;
        private readonly ProcesosRepository _procesosRepository;
        private readonly ReporteModuloDiaRepository _reporteModuloDiaRepository;
        private readonly ReporteModuloDiaDetalleRepository _reporteModuloDiaDetalleRepository;
        private readonly RevisionDeCalidadRepository _revisionDeCalidadRepository;
        private readonly SubCategoriasRepository _subCategoriasRepository;
        private readonly TallasRepository _tallasRepository;
        private readonly TipoEmbalajeRepository _tipoEmbalajeRepository;
        private readonly DocumentosOrdenCompraDetallesRepository _documentosOrdenCompraDetallesRepository;
        private readonly GraficasRepository _graficasRepository;
        private readonly ProcesoPorOrdenCompraDetalleRepository _procesoPorOrdenCompraDetalleRepository;
        private readonly FacturasExportacionRepository _facturasExportacionRepository;
        private readonly FacturasExportacionDetallesRepository _facturasExportacionDetallesRepository;
        private readonly ReportesRepository _reportesRepository;

        public ProduccionServices(AreasRepository areasRepository,
                                    AsignacionesOrdenDetalleRepository asignacionesOrdenDetalleRepository,
                                    AsignacionesOrdenRepository asignacionesOrdenRepository,
                                    CategoriasRepository categoriasRepository,
                                    ClientesRepository clientesRepository,
                                    ColoresRepository coloresRepository,
                                    EstilosRepository estilosRepository,
                                    FuncionesMaquinaRepository funcionesMaquinaRepository,
                                    LotesRepository lotesRepository,
                                    MaquinaHistorialRepository maquinaHistorialRepository,
                                    MaquinasRepository maquinasRepository,
                                    MarcasMaquinaRepository marcasMaquinaRepository,
                                    MaterialesBrindarRepository materialesBrindarRepository,
                                    MaterialesRepository materialesRepository,
                                    ModelosMaquinaRepository modelosMaquinaRepository,
                                    ModulosRepository modulosRepository,
                                    Orde_Ensa_Acab_EtiqRepository orde_Ensa_Acab_EtiqRepository,
                                    OrdenCompraDetallesRepository ordenCompraDetallesRepository,
                                    OrdenCompraRepository ordenCompraRepository,
                                    PedidosOrdenDetallesRepository pedidosOrdenDetallesRepository,
                                    PedidosOrdenRepository pedidosOrdenRepository,
                                    PedidosProduccionDetallesRepository pedidosProduccionDetallesRepository,
                                    PedidosProduccionRepository pedidosProduccionRepository,
                                    PODetallePorPedidoOrdenDetalleRepository PODetallePorPedidoOrdenDetalleRepository,
                                    ProcesosRepository procesosRepository,
                                    ReporteModuloDiaRepository reporteModuloDiaRepository,
                                    ReporteModuloDiaDetalleRepository reporteModuloDiaDetalleRepository,
                                    RevisionDeCalidadRepository revisionDeCalidadRepository,
                                    SubCategoriasRepository subCategoriasRepository,
                                    TallasRepository tallasRepository,
                                    TipoEmbalajeRepository tipoEmbalajeRepository,
                                    DocumentosOrdenCompraDetallesRepository documentosOrdenCompraDetallesRepository,
                                    GraficasRepository graficasRepository,
                                    ProcesoPorOrdenCompraDetalleRepository procesoPorOrdenCompraDetalleRepository,
                                    FacturasExportacionRepository facturasExportacionRepository,
                                    FacturasExportacionDetallesRepository facturasExportacionDetallesRepository,
                                    ReportesRepository reportesRepository

            )
        {


            _areasRepository = areasRepository;
            _asignacionesOrdenDetalleRepository = asignacionesOrdenDetalleRepository;
            _asignacionesOrdenRepository = asignacionesOrdenRepository;
            _categoriasRepository = categoriasRepository;
            _clientesRepository = clientesRepository;
            _coloresRepository = coloresRepository;
            _estilosRepository = estilosRepository;
            _funcionesMaquinaRepository = funcionesMaquinaRepository;
            _lotesRepository = lotesRepository;
            _maquinaHistorialRepository = maquinaHistorialRepository;
            _maquinasRepository = maquinasRepository;
            _marcasMaquinaRepository = marcasMaquinaRepository;
            _materialesBrindarRepository = materialesBrindarRepository;
            _materialesRepository = materialesRepository;
            _modelosMaquinaRepository = modelosMaquinaRepository;
            _modulosRepository = modulosRepository;
            _orde_Ensa_Acab_EtiqRepository = orde_Ensa_Acab_EtiqRepository;
            _ordenCompraDetallesRepository = ordenCompraDetallesRepository;
            _ordenCompraRepository = ordenCompraRepository;
            _pedidosOrdenDetallesRepository = pedidosOrdenDetallesRepository;
            _pedidosOrdenRepository = pedidosOrdenRepository;
            _pedidosProduccionDetallesRepository = pedidosProduccionDetallesRepository;
            _pedidosProduccionRepository = pedidosProduccionRepository;
            _PODetallePorPedidoOrdenDetalleRepository = PODetallePorPedidoOrdenDetalleRepository;
            _procesosRepository = procesosRepository;
            _reporteModuloDiaRepository = reporteModuloDiaRepository;
            _reporteModuloDiaDetalleRepository = reporteModuloDiaDetalleRepository;
            _revisionDeCalidadRepository = revisionDeCalidadRepository;
            _subCategoriasRepository = subCategoriasRepository;
            _tallasRepository = tallasRepository;
            _tipoEmbalajeRepository = tipoEmbalajeRepository;
            _documentosOrdenCompraDetallesRepository = documentosOrdenCompraDetallesRepository;
            _graficasRepository = graficasRepository;
            _procesoPorOrdenCompraDetalleRepository = procesoPorOrdenCompraDetalleRepository;
            _facturasExportacionRepository = facturasExportacionRepository;
            _facturasExportacionDetallesRepository = facturasExportacionDetallesRepository;
            _reportesRepository = reportesRepository;
        }



        #region Areas
        public ServiceResult ListarAreas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _areasRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarAreas(tbArea item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _areasRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarAreas(tbArea item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _areasRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarAreas(tbArea item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _areasRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Asignacion Orden Detalles


        public ServiceResult ListarAsignacionOrdenDetalle(int asor_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _asignacionesOrdenDetalleRepository.List(asor_Id);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarAsignacionOrdenDetalle(tbAsignacionesOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _asignacionesOrdenDetalleRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarAsignacionOrdenDetalle(tbAsignacionesOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _asignacionesOrdenDetalleRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarAsignacionOrdenDetalle(tbAsignacionesOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _asignacionesOrdenDetalleRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Asignacion Orden

        public ServiceResult ListarAsignacionOrden()
        {
            var result = new ServiceResult();
            try
            {
                var list = _asignacionesOrdenRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult FindOrdenCompraDetalles(string id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _asignacionesOrdenRepository.FindAsignacion(id);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarAsignacionOrden(tbAsignacionesOrden item)
        {
            var result = new ServiceResult();
            bool esInt;
            try
            {
                var map = _asignacionesOrdenRepository.Insert(item);
                esInt = int.TryParse(map.MessageStatus, out _);
                if (esInt)
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarAsignacionOrden(tbAsignacionesOrden item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _asignacionesOrdenRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarAsignacionOrden(tbAsignacionesOrden item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _asignacionesOrdenRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Categorias

        public ServiceResult ListarCategorias()
        {
            var result = new ServiceResult();
            try
            {
                var list = _categoriasRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }


        public ServiceResult InsertarCategorias(tbCategoria item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _categoriasRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarCategorias(tbCategoria item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _categoriasRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarCategorias(tbCategoria item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _categoriasRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Clientes

        public ServiceResult ListarClientes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _clientesRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarClientes(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _clientesRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarClientes(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _clientesRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActivarEstadoClientes(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _clientesRepository.ActivarEstado(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }



        public ServiceResult EliminarClientes(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _clientesRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Colores

        public ServiceResult ListarColores()
        {
            var result = new ServiceResult();
            try
            {
                var list = _coloresRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarColores(tbColores item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _coloresRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarColores(tbColores item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _coloresRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarColores(tbColores item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _coloresRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Estilos
        public ServiceResult ListarEstilos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estilosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEstilos(tbEstilos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estilosRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarEstilos(tbEstilos item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _estilosRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarEstilos(tbEstilos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estilosRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region DocumentosOrdenCompraDetalles
        public ServiceResult ListarDocumentosOrdenCompraDetalles(int code_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosOrdenCompraDetallesRepository.ListarByCodeId(code_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDocumentosOrdenCompraDetalles(tbDocumentosOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosOrdenCompraDetallesRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDocumentosOrdenCompraDetalles(tbDocumentosOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _documentosOrdenCompraDetallesRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarDocumentosOrdenCompraDetalles(tbDocumentosOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosOrdenCompraDetallesRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Funciones Maquina
        public ServiceResult ListarFuncionesMaquina()
        {
            var result = new ServiceResult();
            try
            {
                var list = _funcionesMaquinaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarFuncionesMaquina(tbFuncionesMaquina item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _funcionesMaquinaRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarFuncionesMaquina(tbFuncionesMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _funcionesMaquinaRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarFuncionesMaquina(tbFuncionesMaquina item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _funcionesMaquinaRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Lotes
        public ServiceResult ListarLotes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _lotesRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult LotesMateriales(string lote_CodigoLote)
        {
            var result = new ServiceResult();
            try
            {
                var list = _lotesRepository.LotesMateriales(lote_CodigoLote);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarLotes(tbLotes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _lotesRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarLotes(tbLotes item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _lotesRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarLotes(tbLotes item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _lotesRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Maquina Historial
        public ServiceResult ListarMaquinaHistorial()
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _maquinaHistorialRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMaquinaHistorial(tbMaquinaHistorial item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.mahi_FechaInicio.ToString() != "")
                {
                    var map = _maquinaHistorialRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarMaquinaHistorial(tbMaquinaHistorial item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.mahi_FechaInicio.ToString() != "")
                {
                    var map = _maquinaHistorialRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarMaquinaHistorial(tbMaquinaHistorial item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.mahi_Id != 0)
                {
                    var map = _maquinaHistorialRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Maquinas
        public ServiceResult ListarMaquinas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _maquinasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarMaquinas(tbMaquinas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _maquinasRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarMaquinas(tbMaquinas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _maquinasRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarMaquinas(tbMaquinas item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _maquinasRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Marcas Maquina
        public ServiceResult ListarMarcasMaquina()
        {
            var result = new ServiceResult();
            try
            {
                var list = _marcasMaquinaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarMarcasMaquina(tbMarcasMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _marcasMaquinaRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizaMarcasMaquina(tbMarcasMaquina item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _marcasMaquinaRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarMarcasMaquina(tbMarcasMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _marcasMaquinaRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Materiales Brindados
        public ServiceResult ListarMaterialesBrindados()
        {
            var result = new ServiceResult();
            try
            {
                var list = _materialesBrindarRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ListarMaterialesBrindadosFiltrado(int code_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _materialesBrindarRepository.List2(code_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMaterialesBrindados(tbMaterialesBrindar item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _materialesBrindarRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarMaterialesBrindados(tbMaterialesBrindar item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _materialesBrindarRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarMaterialesBrindados(tbMaterialesBrindar item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _materialesBrindarRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Materiales
        public ServiceResult ListarMateriales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _materialesRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMateriales(tbMateriales item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _materialesRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarMateriales(tbMateriales item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _materialesRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarMateriales(tbMateriales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _materialesRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Modelos Maquina
        public ServiceResult ListarModelosMaquina()
        {
            var result = new ServiceResult();
            try
            {
                var list = _modelosMaquinaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarModelosMaquina(tbModelosMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _modelosMaquinaRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarModelosMaquina(tbModelosMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _modelosMaquinaRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarModelosMaquina(tbModelosMaquina item)
        {
            var result = new ServiceResult();
            try
            {

                var map = _modelosMaquinaRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Modulos
        public ServiceResult ListarModulos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _modulosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarModulos(tbModulos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modulosRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarModulos(tbModulos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modulosRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarModulos(tbModulos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modulosRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region orde_Ensa_Acab_EtiqRepository
        public ServiceResult Listarorde_Ensa_Acab_Etiq()
        {
            var result = new ServiceResult();
            try
            {
                var list = _orde_Ensa_Acab_EtiqRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult Insertarorde_Ensa_Acab_Etiq(tbOrde_Ensa_Acab_Etiq item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _orde_Ensa_Acab_EtiqRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Actualizarorde_Ensa_Acab_Etiq(tbOrde_Ensa_Acab_Etiq item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _orde_Ensa_Acab_EtiqRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion

        #region Orden Compra Detalles
        public ServiceResult ListarOrdenCompraDetalles(int orco_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _ordenCompraDetallesRepository.ListByIdOrdenCompra(orco_Id);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult DibujarDetalles(string orco_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _ordenCompraDetallesRepository.DibujarDetalles(orco_Codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult InsertarOrdenCompraDetalles(tbOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.code_CantidadPrenda.ToString() != "")
                {
                    var map = _ordenCompraDetallesRepository.Insert(item);
                    if (map.MessageStatus != "0")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarOrdenCompraDetalles(tbOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.code_CantidadPrenda.ToString() != "")
                {
                    var map = _ordenCompraDetallesRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarOrdenCompraDetalles(tbOrdenCompraDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.code_Id != 0)
                {
                    var map = _ordenCompraDetallesRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult LineaTiempoOrdenCompraDetalles(int orco_Id)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ordenCompraDetallesRepository.LineaTiempoOrdenCompraDetalles(orco_Id);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion

        #region Orden Compra 
        public ServiceResult ListarOrdenCompra()
        {
            var result = new ServiceResult();
            try
            {
                var list = _ordenCompraRepository.List();
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarOrdenCompra(tbOrdenCompra item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.orco_IdCliente.ToString() != "")
                {
                    var map = _ordenCompraRepository.Insert(item);
                    if (map.MessageStatus != "0")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarOrdenCompra(tbOrdenCompra item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.orco_IdCliente.ToString() != "")
                {
                    var map = _ordenCompraRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarOrdenCompra(tbOrdenCompra item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.orco_Id != 0)
                {
                    var map = _ordenCompraRepository.EliminarOrdenCompra(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult LineaTiempoOrdenCompra(string orco_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ordenCompraRepository.LineaTiempo(orco_Codigo);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult FinalizarOrden(tbOrdenCompra item)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _ordenCompraRepository.FinalizarOrdenCompra(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }        
        
        public ServiceResult PO_ExportData()
        {
            var result = new ServiceResult();
            try
            {
                var list = _ordenCompraRepository.ExportData();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion

        #region Proceso por Orden compra detalle
        public ServiceResult ListarProcesoOrdenCompraDetalles(int cade_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _procesoPorOrdenCompraDetalleRepository.Listar(cade_Id);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult DibujadoProcesos(string orco_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _procesoPorOrdenCompraDetalleRepository.DibujarProcesos(orco_Codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult InsertarProcesoOrdenCompraDetalles(tbProcesoPorOrdenCompraDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.code_Id.ToString() != "")
                {
                    var map = _procesoPorOrdenCompraDetalleRepository.Insert(item);
                    if (map.MessageStatus != "0")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult EliminarProcesoPorOrdenCompraDetalle(tbProcesoPorOrdenCompraDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.code_Id != 0)
                {
                    var map = _procesoPorOrdenCompraDetalleRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Pedidos Orden Detalles
        public ServiceResult ListarPedidosOrdenDetalle(int pedi_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosOrdenDetallesRepository.List(pedi_Id);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult PedidosOrdenFind(int prod_Id)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _pedidosOrdenDetallesRepository.Find(prod_Id);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarPedidosOrdenDetalle(tbPedidosOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.prod_Peso.ToString() != "")
                {
                    var map = _pedidosOrdenDetallesRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarPedidosOrdenDetalle(tbPedidosOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.prod_Peso.ToString() != "")
                {
                    var map = _pedidosOrdenDetallesRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarPedidosOrdenDetalle(tbPedidosOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.prod_Id != 0)
                {
                    var map = _pedidosOrdenDetallesRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Pedidos Orden
        public ServiceResult ListarPedidosOrden()
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosOrdenRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPedidosOrden(tbPedidosOrden item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _pedidosOrdenRepository.Insert(item);

                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarPedidosOrden(tbPedidosOrden item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _pedidosOrdenRepository.Update(item);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarPedidosOrden(tbPedidosOrden item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.peor_Id != 0)
                {
                    var map = _pedidosOrdenRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult FinalizapedidoOrden(tbPedidosOrden item)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _pedidosOrdenRepository.FinalizarpedidoOrden(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        #endregion

        #region Pedidos Produccion Detalles
        public ServiceResult ListarPedidosProduccioDetalles(int ppro_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosProduccionDetallesRepository.List(ppro_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPedidosProduccioDetalles(tbPedidosProduccionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _pedidosProduccionDetallesRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarPedidosProduccioDetalles(tbPedidosProduccionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _pedidosProduccionDetallesRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarPedidosProduccioDetalles(tbPedidosProduccionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _pedidosProduccionDetallesRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult FiltrarPedidosProduccioDetalles(int ppro_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosProduccionDetallesRepository.Filter(ppro_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Pedidos Produccion
        public ServiceResult ListarPedidosProduccion()
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosProduccionRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult FindPedidosProduccion(int id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pedidosProduccionRepository.Find(id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPedidosProduccion(tbPedidosProduccion item)
        {
            var result = new ServiceResult();
            bool esInt;
            try
            {
                var map = _pedidosProduccionRepository.Insert(item);
                esInt = int.TryParse(map.MessageStatus, out _);
                if (esInt)
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarPedidosProduccion(tbPedidosProduccion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _pedidosProduccionRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarPedidosProduccion(tbPedidosProduccion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _pedidosProduccionRepository.Delete(item);       
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }         
        }

        public ServiceResult Finalizapedido(tbPedidosProduccion item)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _pedidosProduccionRepository.Finalizapedidoproduccion(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        #endregion

        #region PO Detalle Por Pedido Orden Detalle
        public ServiceResult ListarPODetallePorPedidoOrdenDetalle(int prod_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _PODetallePorPedidoOrdenDetalleRepository.ListxProd_Id(prod_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPODetallePorPedidoOrdenDetalle(tbPODetallePorPedidoOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _PODetallePorPedidoOrdenDetalleRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarPODetallePorPedidoOrdenDetalle(tbPODetallePorPedidoOrdenDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _PODetallePorPedidoOrdenDetalleRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Procesos

        public ServiceResult ListarProcesos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _procesosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarProcesos(tbProcesos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _procesosRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarProcesos(tbProcesos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _procesosRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarProcesos(tbProcesos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _procesosRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult FiltrarProcesos(int proc_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _procesosRepository.Filtrar(proc_Id);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        #endregion

        #region Reporte Modulo Dia


        public ServiceResult ListarReporteModuloDia()
        {
            var result = new ServiceResult();
            try
            {
                var list = _reporteModuloDiaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ListarReporteModuloDiaPorFechas(DateTime? FechaI, DateTime? FechaF)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reporteModuloDiaRepository.ListadoPorFechas(FechaI, FechaF);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarReporteModuloDia(tbReporteModuloDia item)
        {
            var result = new ServiceResult();
            bool esInt;
            try
            {
                var map = _reporteModuloDiaRepository.Insert(item);
                esInt = int.TryParse(map.MessageStatus, out _);
                if (esInt)
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarReporteModuloDia(tbReporteModuloDia item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _reporteModuloDiaRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult FinalizarReporteModuloDia(tbReporteModuloDia item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _reporteModuloDiaRepository.Finalizar(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult EliminarReporteModuloDia(tbReporteModuloDia item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _reporteModuloDiaRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Reporte Modulo Dia Detalle


        public ServiceResult ListarReporteModuloDiaDetalle(int remo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reporteModuloDiaDetalleRepository.List(remo_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarReporteModuloDiaDetalle(tbReporteModuloDiaDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.rdet_TotalDia.ToString() != "")
                {
                    var map = _reporteModuloDiaDetalleRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarReporteModuloDiaDetalle(tbReporteModuloDiaDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.rdet_TotalDia.ToString() != "")
                {
                    var map = _reporteModuloDiaDetalleRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarReporteModuloDiaDetalle(tbReporteModuloDiaDetalle item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.rdet_Id != 0)
                {
                    var map = _reporteModuloDiaDetalleRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Revision de Calidad


        public ServiceResult ListarRevisionDeCalidad()
        {
            var result = new ServiceResult();
            try
            {
                var list = _revisionDeCalidadRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult NuevoListarRevisionDeCalidad(int ensa_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _revisionDeCalidadRepository.NewList(ensa_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRevisionDeCalidad(tbRevisionDeCalidad item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.reca_Descripcion != "")
                {
                    var map = _revisionDeCalidadRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarRevisionDeCalidad(tbRevisionDeCalidad item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.reca_Descripcion != "")
                {
                    var map = _revisionDeCalidadRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarRevisionDeCalidad(tbRevisionDeCalidad item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.reca_Id != 0)
                {
                    var map = _revisionDeCalidadRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Sub Categoria


        public ServiceResult ListarSubCategorias()
        {
            var result = new ServiceResult();
            try
            {
                var list = _subCategoriasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ListarSubCategoriasByIdCategoria(int cate_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _subCategoriasRepository.ListByIdCategoria(cate_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarSubCategorias(tbSubcategoria item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _subCategoriasRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarSubCategorias(tbSubcategoria item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _subCategoriasRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarSubCategorias(tbSubcategoria item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _subCategoriasRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Tallas


        public ServiceResult ListarTallas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tallasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertaTallas(tbTallas item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tall_Nombre != "")
                {
                    var map = _tallasRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarTallas(tbTallas item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tall_Nombre != "")
                {
                    var map = _tallasRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarTallas(tbTallas item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tall_Id != 0)
                {
                    var map = _tallasRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Tipo Embalaje



        public ServiceResult ListarTipoEmbalaje()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tipoEmbalajeRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoEmbalaje(tbTipoEmbalaje item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tiem_Descripcion != "")
                {
                    var map = _tipoEmbalajeRepository.Insert(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarTipoEmbalaje(tbTipoEmbalaje item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tiem_Descripcion != "")
                {
                    var map = _tipoEmbalajeRepository.Update(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarTipoEmbalaje(tbTipoEmbalaje item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.tiem_Id != 0)
                {
                    var map = _tipoEmbalajeRepository.Delete(item);
                    if (map.MessageStatus == "1")
                    {
                        return result.Ok(map);
                    }
                    else
                    {

                        return result.Error(map);
                    }
                }
                else
                {
                    return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Facturas Exportacion
        public ServiceResult ListarFacturasExportacion()
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasExportacionRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFacturasExportacion(tbFacturasExportacion item)
        {
            var result = new ServiceResult();
            bool esInt;
            try
            {
                var map = _facturasExportacionRepository.Insert(item);
                esInt = int.TryParse(map.MessageStatus, out _);
                if (esInt)
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarFacturasExportacion(tbFacturasExportacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarFacturasExportacion(tbFacturasExportacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult FinalizarFacturasExportacion(tbFacturasExportacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionRepository.Finalizar(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult OrdenesCompraDDL()
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasExportacionRepository.OrdenesCompraDDL();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DUCAsDDL()
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasExportacionRepository.DUCAsDDL();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ComprobarNoDUCA(tbFacturasExportacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionRepository.ComprobarNoDUCA(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Facturas Exportacion Detalles
        public ServiceResult ListarFacturasExportacionDetalles(int faex_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasExportacionDetallesRepository.ListByID(faex_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFacturasExportacionDetalles(tbFacturasExportacionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionDetallesRepository.Insert(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ActualizarFacturasExportacionDetalles(tbFacturasExportacionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionDetallesRepository.Update(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {

                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarFacturasExportacionDetalles(tbFacturasExportacionDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasExportacionDetallesRepository.Delete(item);
                if (map.MessageStatus == "1")
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult PODetallesDDL(int id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasExportacionDetallesRepository.POdetalles(id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Graficas
        public ServiceResult Avance_Orden_Compra(tbGraficas item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.Avance_Orden_Compra(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult TotalOrdenesCompraAnual()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.TotalOrdenesCompraAnual();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult TotalOrdenesCompraMensual()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.TotalOrdenesCompraMensual();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult TotalOrdenesCompraDiario()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.TotalOrdenesCompraDiario();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ContadorOrdenesCompraPorEstado()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.ContadorOrdenesCompraPorEstado();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ContadorOrdenesCompraPorEstado_UltimaSemana()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.ContadorOrdenesCompraPorEstado_UltimaSemana();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult VentasSemanales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.VentasSemanales();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }        
        
        public ServiceResult VentasMensuales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.VentasMensuales();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }        
        
        public ServiceResult VentasAnuales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.VentasAnuales();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }        
        
        public ServiceResult OrdenenesEntregadasPendientes_Anual()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.OrdenenesEntregadasPendientes_Anual();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }        
        
        public ServiceResult OrdenenesEntregadasPendientes_Mensual()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.OrdenenesEntregadasPendientes_Mensual();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }        
        
        public ServiceResult OrdenenesEntregadasPendientes_Semanal()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.OrdenenesEntregadasPendientes_Semanal();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult PrendasPedidas(tbGraficas item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.PrendasPedidas(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ClientesProductivos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.ClientesProductivos();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ProductividadModulos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _graficasRepository.ProductividadModulos();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Reportes


        public ServiceResult TiemposMaquinas(tbReportes reportes)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.MaquinasTiempo(reportes);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        
        public ServiceResult ModuloProduccion(tbReportes reportes)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.ModuloProduccion(reportes);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        } 
        
        public ServiceResult PedidosCliente(tbReportes reportes)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.PedidosCliente(reportes);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult PlanificacionPO(int orco_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.PlanificacionPO(orco_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult CostosMaterialesNoBrindados(tbReportes reportes)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.CostosMaterialesNoBrindados(reportes);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Consumo_Materiales(tbReportes reportes)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.Consumo_Materiales(reportes);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult MaquinasUso(tbMaquinas maquinas)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.MaquinasUso(maquinas);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        
        public ServiceResult OrdenesCompraFecha(tbOrdenCompra orden)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.OrdenesCompraFecha(orden);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Inventario(tbMateriales material)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.Inventario(material);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones(DateTime fechaI, DateTime FechaF)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.Importaciones(fechaI, FechaF);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult DevasPendientes(DateTime fechaI, DateTime FechaF)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.DevasPendientes(fechaI, FechaF);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult MateriasDePO(tbOrdenCompra orden)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.MateriasDePO(orden);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ProduccionAreas(tbArea are)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.ProduccionAreas(are);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult MaterialesIngreso(tbPedidosOrden orde)
        {
            var result = new ServiceResult();
            try
            {
                var list = _reportesRepository.MaterialesIngreso(orde);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion
    }
}















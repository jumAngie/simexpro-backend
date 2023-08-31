
using SIMEXPRO.DataAccess.Repositories.Adua;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.BussinessLogic.Services.EventoServices
{
    public class AduanaServices
    {
        private readonly AduanasRepository _aduanasRepository;
        private readonly ArancelesRepository _arancelesRepository;
        private readonly BaseCalculosRepository _baseCalculosRepository;
        private readonly BoletinPagoRepository _boletinPagoRepository;
        private readonly BoletinPagoDetallesRepository _boletinPagoDetallesRepository;
        private readonly CodigoImpuestoRepository _codigoImpuestoRepository;
        private readonly ComercianteIndividualRepository _comercianteIndividualRepository;
        private readonly ConceptoPagoRepository _conceptoPagoRepository;
        private readonly CondicionesRepository _condicionesRepository;
        private readonly CondicionesComercialesRepository _condicionesComercialesRepository;
        private readonly Declaraciones_ValorHistorialRepository _declaraciones_ValorHistorialRepository;
        private readonly Declaraciones_ValorRepository _declaraciones_ValorRepository;
        private readonly DocumentosContratosRepository _documentosContratosRepository;
        private readonly DocumentosdeSoporteRepository _documentosdeSoporteRepository;
        private readonly DocumentosPDFRepository _documentosPDFRepository;
        private readonly DucaRepository _ducaRepository;
        private readonly EstadoBoletinRepository _estadoBoletinRepository;
        private readonly EstadoMercanciasRepository _estadoMercanciasRepository;
        private readonly FacturasRepository _facturasRepository;
        private readonly FormasdePagoRepository _formasdePagoRepository;
        private readonly ImpuestosporAracelRepository _impuestosporAracelRepository;
        private readonly ImpuestosRepository _impuestosRepository;
        private readonly IncotermRepository _incotermRepository;
        private readonly IntermediarioRepository _intermediarioRepository;
        private readonly ItemsRepository _itemsRepository;
        private readonly LiquidacionGeneralRepository _liquidacionGeneralRepository;
        private readonly LiquidacionPorLineaRepository _liquidacionPorLineaRepository;
        private readonly LugaresEmbarqueRepository _lugaresEmbarqueRepository;
        private readonly MarcasRepository _marcasRepository;
        private readonly ModoTransporteRepository _modoTransporteRepository;
        private readonly NivelesComercialesRepository _nivelesComercialesRepository;
        private readonly PersonaJuridicaRepository _personaJuridicaRepository;
        private readonly PersonaNaturalRepository _personaNaturalRepository;
        private readonly PersonasRepository _personasRepository;
        private readonly TipoDocumentoRepository _tipoDocumentoRepository;
        private readonly TipoIntermediarioRepository _tipoIntermediarioRepository;
        private readonly TipoLiquidacionRepository _tipoLiquidacionRepository;
        private readonly TiposIdentificacionRepository _tiposIdentificacionRepository;
        private readonly TransporteRepository _transporteRepository;
        private readonly AduanaGraficasRepository _aduanagraficasrepository;

        public AduanaServices(AduanasRepository AduanasRepository, ArancelesRepository ArancelesRepository, BaseCalculosRepository BaseCalculosRepository, BoletinPagoRepository BoletinPagoRepository, BoletinPagoDetallesRepository BoletinPagoDetallesRepository,
                                CodigoImpuestoRepository CodigoImpuestoRepository, ComercianteIndividualRepository ComercianteIndividualRepository, ConceptoPagoRepository ConceptoPagoRepository, CondicionesRepository CondicionesRepository,
                                CondicionesComercialesRepository CondicionesComercialesRepository,Declaraciones_ValorHistorialRepository Declaraciones_ValorHistorialRepository, Declaraciones_ValorRepository Declaraciones_ValorRepository,
                                DocumentosContratosRepository DocumentosContratosRepository, DocumentosdeSoporteRepository DocumentosdeSoporteRepository, DocumentosPDFRepository DocumentosPDFRepository, 
                                DucaRepository DucaRepository, EstadoBoletinRepository EstadoBoletinRepository, EstadoMercanciasRepository EstadoMercanciasRepository, FacturasRepository FacturasRepository , FormasdePagoRepository FormasdePagoRepository, ImpuestosporAracelRepository ImpuestosporAracelRepository,
                                ImpuestosRepository ImpuestosRepository, IncotermRepository IncotermRepository, IntermediarioRepository IntermediarioRepository, ItemsRepository ItemsRepository, LiquidacionGeneralRepository LiquidacionGeneralRepository,
                                LiquidacionPorLineaRepository LiquidacionPorLineaRepository, LugaresEmbarqueRepository LugaresEmbarqueRepository, MarcasRepository MarcasRepository, ModoTransporteRepository ModoTransporteRepository,
                                NivelesComercialesRepository NivelesComercialesRepository, PersonaJuridicaRepository PersonaJuridicaRepository, PersonaNaturalRepository PersonaNaturalRepository, PersonasRepository PersonasRepository,
                                 TipoDocumentoRepository TipoDocumentoRepository, TipoIntermediarioRepository TipoIntermediarioRepository,TipoLiquidacionRepository TipoLiquidacionRepository, TiposIdentificacionRepository TiposIdentificacionRepository, TransporteRepository TransporteRepository,
                                AduanaGraficasRepository AduanaGraficasRepository)
        {
            _aduanasRepository = AduanasRepository;
            _arancelesRepository = ArancelesRepository;
            _baseCalculosRepository = BaseCalculosRepository;
            _boletinPagoRepository = BoletinPagoRepository;
            _boletinPagoDetallesRepository = BoletinPagoDetallesRepository;
            _codigoImpuestoRepository = CodigoImpuestoRepository;
            _comercianteIndividualRepository = ComercianteIndividualRepository;
            _conceptoPagoRepository = ConceptoPagoRepository;
            _condicionesRepository = CondicionesRepository;
            _condicionesComercialesRepository = CondicionesComercialesRepository;
            _declaraciones_ValorHistorialRepository = Declaraciones_ValorHistorialRepository;
            _declaraciones_ValorRepository = Declaraciones_ValorRepository;
            _documentosContratosRepository = DocumentosContratosRepository;
            _documentosdeSoporteRepository = DocumentosdeSoporteRepository;
            _documentosPDFRepository = DocumentosPDFRepository;
            _ducaRepository = DucaRepository;
            _estadoBoletinRepository = EstadoBoletinRepository;
            _estadoMercanciasRepository = EstadoMercanciasRepository;
            _facturasRepository = FacturasRepository;
            _formasdePagoRepository = FormasdePagoRepository;
            _impuestosporAracelRepository = ImpuestosporAracelRepository;
            _impuestosRepository = ImpuestosRepository;
            _incotermRepository = IncotermRepository;
            _intermediarioRepository = IntermediarioRepository;
            _itemsRepository = ItemsRepository;
            _liquidacionGeneralRepository = LiquidacionGeneralRepository;
            _liquidacionPorLineaRepository = LiquidacionPorLineaRepository;
            _lugaresEmbarqueRepository = LugaresEmbarqueRepository;
            _marcasRepository = MarcasRepository;
            _modoTransporteRepository = ModoTransporteRepository;
            _nivelesComercialesRepository = NivelesComercialesRepository;
            _personaJuridicaRepository = PersonaJuridicaRepository;
            _personaNaturalRepository = PersonaNaturalRepository;
            _personasRepository = PersonasRepository;
            _tipoDocumentoRepository = TipoDocumentoRepository;
            _tipoIntermediarioRepository = TipoIntermediarioRepository;
            _tipoLiquidacionRepository = TipoLiquidacionRepository;
            _tiposIdentificacionRepository = TiposIdentificacionRepository;
            _transporteRepository = TransporteRepository;
            _aduanagraficasrepository = AduanaGraficasRepository;
        }
        #region Aduanas
        public ServiceResult ListarAduanas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanasRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarAduanas(tbAduanas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aduanasRepository.Insert(item);
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

        public ServiceResult ActualizarAduanas(tbAduanas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aduanasRepository.Update(item);
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

        public ServiceResult EliminarAduanas(tbAduanas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aduanasRepository.Delete(item);
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

        #region Aranceles
        public ServiceResult ListarAranceles()
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _arancelesRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarAranceles(tbAranceles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _arancelesRepository.Insert(item);
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

        public ServiceResult ActualizarAranceles(tbAranceles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _arancelesRepository.Update(item);
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

        public ServiceResult BuscarCategoriaArancel(string aran_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var map = _arancelesRepository.Categoria(aran_Codigo);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        #endregion

        #region BaseCalculos
        public ServiceResult ListarBaseCalculos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _baseCalculosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarBaseCalculos(tbBaseCalculos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _baseCalculosRepository.Insert(item);
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

        public ServiceResult ActualizarBaseCalculos(tbBaseCalculos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _baseCalculosRepository.Update(item);
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

        #region BoletinPago
        public ServiceResult ListarBoletinPago()
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _boletinPagoRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarBoletinPago(tbBoletinPago item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _boletinPagoRepository.Insert(item);
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

        public ServiceResult ActualizarBoletinPago(tbBoletinPago item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _boletinPagoRepository.Update(item);
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

        #region Boletin de Pago detalles
        public ServiceResult ListarDetallesBoletinPagoByIdBoletin(int Id)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _boletinPagoDetallesRepository.ListByIdBoletinPago(Id);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarBoletinPagoDetalles(tbBoletinPagoDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _boletinPagoDetallesRepository.Insert(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarBoletinPagoDetalles(tbBoletinPagoDetalles item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _boletinPagoDetallesRepository.Update(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region CodigoImpuesto
        public ServiceResult ListarCodigoImpuesto()
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _codigoImpuestoRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCodigoImpuesto(tbCodigoImpuesto item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _codigoImpuestoRepository.Insert(item);
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

        public ServiceResult ActualizarCodigoImpuesto(tbCodigoImpuesto item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _codigoImpuestoRepository.Update(item);
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

        public ServiceResult EliminarCodigoImpuesto(tbCodigoImpuesto item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _codigoImpuestoRepository.Delete(item);
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

        #region ComercianteIndividual
        public ServiceResult ListarComercianteIndividual()
        {
            var resultado = new ServiceResult();


            try
            {
                var list = _comercianteIndividualRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarComercianteIndividual(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.Insert(item);
                if (map.MessageStatus != "0")
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

        public ServiceResult InsertarComercianteIndividualTap2(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.InsertTap2(item);
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

        public ServiceResult InsertarComercianteIndividualTap3(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.InsertTap3(item);
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

        public ServiceResult InsertarComercianteIndividualTap4(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.InsertTap4(item);
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

        public ServiceResult InsertarComercianteIndividualTap5(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.InsertTap5(item);
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



        public ServiceResult ActualizarComercianteIndividual(tbComercianteIndividual item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _comercianteIndividualRepository.Update(item);
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

        #region ConceptoPago
        public ServiceResult ListarConceptoPago()
        {
            var result = new ServiceResult();
            try
            {
                var list = _conceptoPagoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarConceptoPago(tbConceptoPago item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _conceptoPagoRepository.Insert(item);
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

        public ServiceResult ActualizarConceptoPago(tbConceptoPago item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _conceptoPagoRepository.Update(item);

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

        #region Condiciones

        public ServiceResult ListarCondiciones()
        {
            var result = new ServiceResult();
            try
            {
                var list = _condicionesRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarCondiciones(tbCondiciones item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _condicionesRepository.Insert(item);
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

        public ServiceResult ActualizarCondiciones(tbCondiciones item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _condicionesRepository.Update(item);
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

        #region CondicionesComerciales

        public ServiceResult ListarCondicionesComerciales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _condicionesComercialesRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarCondicionesComerciales(tbCondicionesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _condicionesComercialesRepository.Insert(item);
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

        public ServiceResult ActualizarCondicionesComerciales(tbCondicionesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _condicionesComercialesRepository.Update(item);
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

        public ServiceResult EliminarCondicionesComerciales(tbCondicionesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                if (item.coco_Id != 0)
                {
                    var map = _condicionesComercialesRepository.Delete(item);
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

        #region Declaraciones_Valor

        public ServiceResult FindDeclarante(string decl_NumeroIdentificacion)
        {
            var result = new ServiceResult();
            try
            {
                var list = _declaraciones_ValorRepository.Find(decl_NumeroIdentificacion);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ListarDeclaraciones_Valor()
        {
            var result = new ServiceResult();
            try
            {
                var list = _declaraciones_ValorRepository.ListVW();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDeclaraciones_ValorTab1(tbDeclaraciones_Valor item, tbDeclarantes itemDecl, tbImportadores itemImp)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _declaraciones_ValorRepository.InsertTab1(item, itemDecl, itemImp);
                
                if (respuesta.MessageStatus != "0")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDeclaraciones_ValorTab2(tbDeclaraciones_Valor item, tbDeclarantes declProv, tbDeclarantes declInte, tbProveedoresDeclaracion itemProv, tbIntermediarios itemInte)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _declaraciones_ValorRepository.InsertTab2(item, declProv, declInte, itemProv, itemInte);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDeclaraciones_ValorTab3(tbDeclaraciones_Valor item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _declaraciones_ValorRepository.InsertTab3(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDeclaraciones_ValorTab1(tbDeclaraciones_Valor item, tbDeclarantes itemDecl, tbImportadores itemImp)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _declaraciones_ValorRepository.UpdateTab1(item, itemDecl, itemImp);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        //public ServiceResult ActualizarDeclaraciones_ValorTab2(tbDeclaraciones_Valor item, tbDeclarantes declProv, tbDeclarantes declInte, tbProveedoresDeclaracion itemProv, tbIntermediarios itemInte)
        //{
        //    var result = new ServiceResult();
        //    try
        //    {
        //        var respuesta = _declaraciones_ValorRepository.UpdateTab2(item, declProv, declInte, itemProv, itemInte);
        //        if (respuesta.MessageStatus == "1")
        //        {
        //            return result.Ok(respuesta);
        //        }
        //        else
        //        {
        //            return result.Error(respuesta);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return result.Error(ex.Message);
        //    }
        //}

        //public ServiceResult ActualizarDeclaraciones_ValorTab3(tbDeclaraciones_Valor item)
        //{
        //    var result = new ServiceResult();
        //    try
        //    {
        //        var respuesta = _declaraciones_ValorRepository.UpdateTab3(item);
        //        if (respuesta.MessageStatus == "1")
        //        {
        //            return result.Ok(respuesta);
        //        }
        //        else
        //        {
        //            return result.Error(respuesta);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return result.Error(ex.Message);
        //    }
        //}

        public ServiceResult EliminarDeclaraciones_Valor(tbDeclaraciones_Valor item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _declaraciones_ValorRepository.Delete(item);
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

        #region DocumentosContratos
        public ServiceResult ListarDocumentosContratos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosContratosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDocumentosContratos(tbDocumentosContratos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosContratosRepository.Insert(item);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDocumentosContratos(tbDocumentosContratos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosContratosRepository.Update(item);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarDocumentosContratos(tbDocumentosContratos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosContratosRepository.Delete(item);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        #endregion

        #region DocumentosdeSoporte
        public ServiceResult ListarDocumentosdeSoporte()
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosdeSoporteRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDocumentosdeSoporte(tbDocumentosDeSoporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosdeSoporteRepository.Insert(item);
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

        public ServiceResult ActualizarDocumentosdeSoporte(tbDocumentosDeSoporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosdeSoporteRepository.Update(item);
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

        public ServiceResult EliminarDocumentosdeSoporte(tbDocumentosDeSoporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosdeSoporteRepository.Delete(item);
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

        #region DocumentosPDF
        public ServiceResult ListarDocumentosPDF()
        {
            var result = new ServiceResult();
            try
            {
                var list = _documentosPDFRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDocumentosPDF(tbDocumentosPDF item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosPDFRepository.Insert(item);
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

        public ServiceResult ActualizarDocumentosPDF(tbDocumentosPDF item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosPDFRepository.Update(item);
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

        public ServiceResult EliminarDocumentosPDF(tbDocumentosPDF item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _documentosPDFRepository.Delete(item);
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

        #region Duca
        public ServiceResult ListarDuca()
        {
            var result = new ServiceResult();
            try
            {
                var list = _ducaRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult VerificarExistencia(string duca_No_Duca)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _ducaRepository.VerificarExistencia(duca_No_Duca);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDucaTap1(tbDuca item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.Insert(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDucaTap2(tbDuca item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.InsertTap2(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDucaTap3(tbDocumentosDeSoporte item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.InsertTap3(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDucaTap1(tbDuca item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.Update(item); 
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDucaTap2(tbDuca item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.UpdateTap2(item);
                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarDucaTap3(tbDocumentosDeSoporte item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _ducaRepository.UpdateTap3(item);
                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

      
        #endregion

        #region EstadoBoletin
        public ServiceResult ListarEstadoBoletin()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadoBoletinRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEstadoBoletin(tbEstadoBoletin item)
        {
            var resultado = new ServiceResult();
            try
            {
                var respuesta = _estadoBoletinRepository.Insert(item);
                if (respuesta.MessageStatus == "1")
                {
                    return resultado.Ok(respuesta);
                }
                else
                {
                    return resultado.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarEstadoBoletin(tbEstadoBoletin item)
        {
            var resultado = new ServiceResult();

            try
            {
                var respuesta = _estadoBoletinRepository.Update(item);
                if (respuesta.MessageStatus == "1")
                {
                    return resultado.Ok(respuesta);
                }
                else
                {
                    return resultado.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        #endregion

        #region EstadoMercancias
     
        public ServiceResult ListarEstadoMercancias()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadoMercanciasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEstadoMercancias(tbEstadoMercancias item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadoMercanciasRepository.Insert(item);
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

        public ServiceResult ActualizarEstadoMercancias(tbEstadoMercancias item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadoMercanciasRepository.Update(item);
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

        public ServiceResult EliminarEstadoMercancias(tbEstadoMercancias item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadoMercanciasRepository.Delete(item);
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

        #region Facturas

        public ServiceResult ListarFacturas(int deva_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _facturasRepository.List(deva_Id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarFacturas(tbFacturas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasRepository.Insert(item);
                if (map.MessageStatus != "0")
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

        public ServiceResult ActualizarFacturas(tbFacturas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasRepository.Update(item);
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

        public ServiceResult EliminarFacturas(tbFacturas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facturasRepository.Delete(item);
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

        #region FormasdePago
        public ServiceResult ListarFormasdePago()
        {
            var result = new ServiceResult();
            try
            {
                var list = _formasdePagoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFormasdePago(tbFormasdePago item)
        {
            var resultado = new ServiceResult();

            try
            {
                var respuesta = _formasdePagoRepository.Insert(item);
                if (respuesta.MessageStatus == "1")
                {
                    return resultado.Ok(respuesta);
                }
                else
                {
                    return resultado.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarFormasdePago(tbFormasdePago item)
        {
            var resultado = new ServiceResult();

            try
            {
                var respuesta = _formasdePagoRepository.Update(item);
                if (respuesta.MessageStatus == "1")
                {
                    return resultado.Ok(respuesta);
                }
                else
                {
                    return resultado.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult EliminarFormasdePago(tbFormasdePago item)
        {
            var resultado = new ServiceResult();

            try
            {
                var respuesta = _formasdePagoRepository.Delete(item);
                if (respuesta.MessageStatus == "1")
                {
                    return resultado.Ok(respuesta);
                }
                else
                {
                    return resultado.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        #endregion

        #region ImpuestosPorArancel
        public ServiceResult ListarImpuestosPorArancel()
        {
            var result = new ServiceResult();
            try
            {
                var list = _impuestosporAracelRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarImpuestosPorArancel(tbImpuestosPorArancel item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosporAracelRepository.Insert(item);
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

        public ServiceResult ActualizarImpuestosPorArancel(tbImpuestosPorArancel item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosporAracelRepository.Update(item);
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

        public ServiceResult EliminarImpuestosPorArancel(tbImpuestosPorArancel item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosporAracelRepository.Delete(item);
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

        #region Impuestos
        public ServiceResult ListarImpuestos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _impuestosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarImpuestos(tbImpuestos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosRepository.Insert(item);
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

        public ServiceResult ActualizarImpuestos(tbImpuestos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosRepository.Update(item);
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

        public ServiceResult EliminarImpuestos(tbImpuestos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _impuestosRepository.Delete(item);
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

        #region Incoterm
        public ServiceResult ListarIncoterm()
        {
            var result = new ServiceResult();
            try
            {
                var list = _incotermRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarIncoterm(tbIncoterm item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _incotermRepository.Insert(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarIncoterm(tbIncoterm item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _incotermRepository.Update(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error(respuesta);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarIncoterm(tbIncoterm item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _incotermRepository.Delete(item);
                if (respuesta.MessageStatus == "1")
                {
                    return result.Ok(respuesta);
                }
                else
                {
                    return result.Error();
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Intermediarios
        public ServiceResult ListarIntermediarios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _intermediarioRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarIntermediarios(tbIntermediarios item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _intermediarioRepository.Insert(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarIntermediarios(tbIntermediarios item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _intermediarioRepository.Update(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarIntermediarios(tbIntermediarios item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _intermediarioRepository.Delete(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Items
        public ServiceResult ListarItems(int fact_Id)
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _itemsRepository.List(fact_Id);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarItems(tbItems item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _itemsRepository.Insert(item);
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

        public ServiceResult ActualizarItems(tbItems item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _itemsRepository.Update(item);
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

        public ServiceResult EliminarItems(tbItems item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _itemsRepository.Delete(item);
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

        #region LiquidacionGeneral
        public ServiceResult ListarLiquidacionGeneral()
        {
            var result = new ServiceResult();
            try
            {
                var list = _liquidacionGeneralRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarLiquidacionGeneral(tbLiquidacionGeneral item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _liquidacionGeneralRepository.Insert(item);
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

        public ServiceResult ActualizarLiquidacionGeneral(tbLiquidacionGeneral item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _liquidacionGeneralRepository.Update(item);
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

        public ServiceResult EliminarLiquidacionGeneral(tbLiquidacionGeneral item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _liquidacionGeneralRepository.Delete(item);
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

        #region LiquidacionPorLinea
        public ServiceResult ListarLiquidacionPorLinea()
        {
            var result = new ServiceResult();
            try
            {
                var list = _liquidacionPorLineaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarLiquidacionPorLinea(tbLiquidacionPorLinea item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _liquidacionPorLineaRepository.Insert(item);
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

        public ServiceResult ActualizarLiquidacionPorLinea(tbLiquidacionPorLinea item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _liquidacionPorLineaRepository.Update(item);
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

        public ServiceResult EliminarLiquidacionPorLinea(tbLiquidacionPorLinea item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _liquidacionPorLineaRepository.Delete(item);
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

        #region LugaresEmbarque
        public ServiceResult ListarLugaresEmbarque(string codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _lugaresEmbarqueRepository.List(codigo);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarLugaresEmbarque(tbLugaresEmbarque item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _lugaresEmbarqueRepository.Insert(item);
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

        public ServiceResult ActualizarLugaresEmbarque(tbLugaresEmbarque item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _lugaresEmbarqueRepository.Update(item);
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

        public ServiceResult EliminarLugaresEmbarque(tbLugaresEmbarque item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _lugaresEmbarqueRepository.Delete(item);
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

        #region Marcas
        public ServiceResult ListarMarcas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _marcasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMarcas(tbMarcas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _marcasRepository.Insert(item);
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

        public ServiceResult ActualizarMarcas(tbMarcas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _marcasRepository.Update(item);
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

        public ServiceResult EliminarMarcas(tbMarcas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _marcasRepository.Delete(item);
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

        #region ModoTransporte
        public ServiceResult ListarModoTransporte()
        {
            var result = new ServiceResult();
            try
            {
                var list = _modoTransporteRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarModoTransporte(tbModoTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modoTransporteRepository.Insert(item);
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

        public ServiceResult ActualizarModoTransporte(tbModoTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modoTransporteRepository.Update(item);
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

        public ServiceResult EliminarModoTransporte(tbModoTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _modoTransporteRepository.Delete(item);
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

        #region NivelesComerciales
        public ServiceResult ListarNivelesComerciales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _nivelesComercialesRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarNivelesComerciales(tbNivelesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _nivelesComercialesRepository.Insert(item);
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

        public ServiceResult ActualizarNivelesComerciales(tbNivelesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _nivelesComercialesRepository.Update(item);
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

        public ServiceResult EliminarNivelesComerciales(tbNivelesComerciales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _nivelesComercialesRepository.Delete(item);
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

        #region PersonaJuridica
        public ServiceResult ListarPersonaJuridica()
        {
            var result = new ServiceResult();
            try
            {
                var list = _personaJuridicaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPersonaJuridica(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.Insert(item);
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

        public ServiceResult InsertarPersonaJuridicaTap2(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.InsertTap2(item);
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

        public ServiceResult InsertarPersonaJuridicaTap3(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.InsertTap3(item);
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

        public ServiceResult InsertarPersonaJuridicaTap4(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.InsertTap4(item);
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

        public ServiceResult InsertarPersonaJuridicaTap5(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.InsertTap5(item);
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

        public ServiceResult ActualizarPersonaJuridica(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.Update(item);
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

        public ServiceResult EliminarPersonaJuridica(tbPersonaJuridica item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaJuridicaRepository.Delete(item);
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

        #region PersonaNatural
        public ServiceResult ListarPersonaNatural()
        {
            var result = new ServiceResult();
            try
            {
                var list = _personaNaturalRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex) { return result.Error(ex.Message); }
        }


        public ServiceResult InsertarPersonaNatural(tbPersonaNatural item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaNaturalRepository.Insert(item);
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

        public ServiceResult ActualizarPersonaNatural(tbPersonaNatural item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaNaturalRepository.Update(item);
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

        public ServiceResult EliminarPersonaNatural(tbPersonaNatural item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personaNaturalRepository.Delete(item);
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

        #region Personas
        public ServiceResult ListarPersonas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _personasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarPersonas(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personasRepository.Insert(item);
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

        public ServiceResult ActualizarPersonas(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personasRepository.Update(item);
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

        public ServiceResult EliminarPersonas(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _personasRepository.Delete(item);
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

        #region TipoDocumento
        public ServiceResult ListarTipoDocumento()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tipoDocumentoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoDocumento(tbTipoDocumento item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Insert(item);
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

        public ServiceResult ActualizarTipoDocumento(tbTipoDocumento item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Update(item);
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

        public ServiceResult EliminarTipoDocumento(tbTipoDocumento item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Delete(item);
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

        #region TipoIntermediario
        public ServiceResult ListarTipoIntermediario()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tipoIntermediarioRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoIntermediario(tbTipoIntermediario item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoIntermediarioRepository.Insert(item);
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

        public ServiceResult ActualizarTipoIntermediario(tbTipoIntermediario item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoIntermediarioRepository.Update(item);
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

        public ServiceResult EliminarTipoIntermediario(tbTipoIntermediario item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoIntermediarioRepository.Delete(item);
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

        #region TipoLiquidacion
        public ServiceResult ListarTipoLiquidacion()
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _tipoLiquidacionRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoLiquidacion(tbTipoLiquidacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoLiquidacionRepository.Insert(item);
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

        public ServiceResult ActualizarTipoLiquidacion(tbTipoLiquidacion item)
        {
            var result = new ServiceResult();
            try
            {var map = _tipoLiquidacionRepository.Update(item);
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

        public ServiceResult EliminarTipoLiquidacion(tbTipoLiquidacion item)
        {
            var result = new ServiceResult();
            try
            {
                    var map = _tipoLiquidacionRepository.Delete(item);
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

        #region TiposIdentificacion
        public ServiceResult ListarTiposIdentificacion()
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _tiposIdentificacionRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }


        public ServiceResult InsertarTiposIdentificacion(tbTiposIdentificacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tiposIdentificacionRepository.Insert(item);
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

        public ServiceResult ActualizarTiposIdentificacion(tbTiposIdentificacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tiposIdentificacionRepository.Update(item);
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

        public ServiceResult EliminarTiposIdentificacion(tbTiposIdentificacion item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tiposIdentificacionRepository.Delete(item);
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

        #region Transporte
        public ServiceResult ListarTransporte()
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _transporteRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTransporte(tbTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _transporteRepository.Insert(item);
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

        public ServiceResult ActualizarTransporte(tbTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _transporteRepository.Update(item);
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

        public ServiceResult EliminarTransporte(tbTransporte item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _transporteRepository.Delete(item);
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

        #region Graficas
        public ServiceResult ExportadoresPorPais_CantidadPorcentaje()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.ExportadoresPorPais_CantidadPorcentaje();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EstadosMercancias_CantidadPorcentaje()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.EstadosMercancias_CantidadPorcentaje();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult AduanasIngreso_CantidadPorcentaje()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.AduanasIngreso_CantidadPorcentaje();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Contador_Anio()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Contador_Anio();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Contador_Mes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Contador_Mes();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Contador_Semana()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Contador_Semana();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Semana()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Semana();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Mes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Mes();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Importaciones_Anio()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.Importaciones_Anio();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult RegimenesAduaneros_CantidadPorcentaje()
        {
            var result = new ServiceResult();
            try
            {
                var list = _aduanagraficasrepository.RegimenesAduaneros_CantidadPorcentaje();
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
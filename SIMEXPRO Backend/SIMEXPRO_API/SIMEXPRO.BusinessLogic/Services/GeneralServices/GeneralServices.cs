
using SIMEXPRO.DataAccess.Repositories.Gral;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.BussinessLogic.Services.GeneralServices
{
    public class GeneralServices
    {
        private readonly AldeasRepository _aldeasRepository;
        private readonly CargosRepository _cargosRepository;
        private readonly CiudadesRepository _ciudadesRepository;
        private readonly ColoniasRepository _coloniasRepository;
        private readonly EmpleadosRepository _empleadosRepository;
        private readonly EstadosCivilesRepository _estadosCivilesRepository;
        private readonly FormasEnvioRepository _formasEnvioRepository;
        private readonly MonedasRepository _monedasRepository;
        private readonly OficinasRepository _oficinasRepository;
        private readonly OficioProfesionesRepository _oficioProfesionesRepository;
        private readonly PaisesRepository _paisesRepository;
        private readonly ProveedoresRepository _proveedoresRepository;
        private readonly ProvinciasRepository _provinciasRepository;
        private readonly UnidadMedidasRepository _unidadMedidasRepository;



        public GeneralServices(
            AldeasRepository aldeasRepository,
            CargosRepository cargosRepository,
            CiudadesRepository ciudadesRepository,
            ColoniasRepository coloniasRepository,
            EmpleadosRepository empleadosRepository,
            EstadosCivilesRepository estadosCivilesRepository,
            FormasEnvioRepository formasEnvioRepository,
            MonedasRepository monedasRepository,
            OficinasRepository oficinasRepository,
            OficioProfesionesRepository oficioProfesionesRepository,
            PaisesRepository paisesRepository,
            ProveedoresRepository proveedoresRepository,
            ProvinciasRepository provinciasRepository,
            UnidadMedidasRepository unidadMedidasRepository
                                )
        {
            _aldeasRepository = aldeasRepository;
            _cargosRepository = cargosRepository;
            _ciudadesRepository = ciudadesRepository;
            _coloniasRepository = coloniasRepository;
            _empleadosRepository = empleadosRepository;
            _estadosCivilesRepository = estadosCivilesRepository;
            _formasEnvioRepository = formasEnvioRepository;
            _monedasRepository = monedasRepository;
            _oficinasRepository = oficinasRepository;
            _oficioProfesionesRepository = oficioProfesionesRepository;
            _paisesRepository = paisesRepository;
            _proveedoresRepository = proveedoresRepository;
            _provinciasRepository = provinciasRepository;
            _unidadMedidasRepository = unidadMedidasRepository;

        }

        #region Aldeas
        public ServiceResult ListarAldeas()
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _aldeasRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult AldeasPorCiudades(int Id)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _aldeasRepository.AldeasPorCiudades(Id);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        public ServiceResult InsertarAldeas(tbAldeas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aldeasRepository.Insert(item);
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

        public ServiceResult ActualizarAldeas(tbAldeas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aldeasRepository.Update(item);
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

        public ServiceResult EliminarAldeas(tbAldeas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _aldeasRepository.Delete(item);
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

        #region Cargos
        public ServiceResult ListarCargos(bool? carg_EsAduana)
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _cargosRepository.List(carg_EsAduana);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCargos(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _cargosRepository.Insert(item);
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

        public ServiceResult ActualizarCargos(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _cargosRepository.Update(item);
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

        #region Ciudades
        public ServiceResult ListarCiudades(bool? ciud_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _ciudadesRepository.List(ciud_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult CiudadesPorProvincia(int Id)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _ciudadesRepository.CiudadesPorProvincia(Id);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCiudades(tbCiudades item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _ciudadesRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarCiudades(tbCiudades item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _ciudadesRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }

        public ServiceResult EliminarCiudades(tbCiudades item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _ciudadesRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Colonias
        public ServiceResult ListarColonias()
        {
            var result = new ServiceResult();
            try
            {
                var list = _coloniasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ColoniasPorCiudades(int Id)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _coloniasRepository.ColoniasPorCiudades(Id);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarColonias(tbColonias item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _coloniasRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarColonias(tbColonias item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _coloniasRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarColonias(tbColonias item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _coloniasRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        #endregion

        #region Empleados
        public ServiceResult ListarEmpleados(bool? empl_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.List(empl_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ListarEmpleadosSinUsuario(bool? empl_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.ListNoTieneUsuario(empl_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadosRepository.Insert(item);
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

        public ServiceResult ActualizarEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadosRepository.Update(item);
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

        public ServiceResult EliminarEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadosRepository.Delete(item);
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

        public ServiceResult ReactivarEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadosRepository.Reactivar(item);
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

        #region EstadosCiviles
        public ServiceResult ListarEstadosCiviles(bool? escv_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadosCivilesRepository.ListarEstadosCiviles(escv_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }

        public ServiceResult InsertarEstadosCiviles(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadosCivilesRepository.Insert(item);
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

        public ServiceResult ActualizarEstadosCiviles(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadosCivilesRepository.Update(item);
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

        public ServiceResult EliminarEstadosCiviles(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadosCivilesRepository.Delete(item);
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

        #region Formas_Envio
            public ServiceResult ListarFormas_Envio()
        {
            var result = new ServiceResult();
            try
            {
                var list = _formasEnvioRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFormas_Envio(tbFormas_Envio item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _formasEnvioRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarFormas_Envio(tbFormas_Envio item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _formasEnvioRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarFormas_Envio(tbFormas_Envio item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _formasEnvioRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Monedas
        public ServiceResult ListarMonedas(bool? mone_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _monedasRepository.List(mone_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMonedas(tbMonedas item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _monedasRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarMonedas(tbMonedas item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _monedasRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }

        public ServiceResult EliminarMonedas(tbMonedas item)
        {

            var result = new ServiceResult();
            try
            {
                var list = _monedasRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Oficinas
        public ServiceResult ListarOficinas()
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _oficinasRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarOficinas(tbOficinas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _oficinasRepository.Insert(item);
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

        public ServiceResult ActualizarOficinas(tbOficinas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _oficinasRepository.Update(item);
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

        public ServiceResult EliminarOficinas(tbOficinas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _oficinasRepository.Delete(item);
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

        #region Oficio_Profesiones
        public ServiceResult ListarOficio_Profesiones()
        {
            var result = new ServiceResult();

            try
            {
                var list = _oficioProfesionesRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {

                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarOficio_Profesiones(tbOficio_Profesiones item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _oficioProfesionesRepository.Insert(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarOficio_Profesiones(tbOficio_Profesiones item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _oficioProfesionesRepository.Update(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarOficio_Profesiones(tbOficio_Profesiones item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _oficioProfesionesRepository.Delete(item);

                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Paises
        public ServiceResult ListarPaises(bool? pais_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _paisesRepository.List(pais_EsAduana);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex);
            }
        }

        public ServiceResult InsertarPaises(tbPaises item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _paisesRepository.Insert(item);
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

        public ServiceResult ActualizarPaises(tbPaises item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _paisesRepository.Update(item);
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

        #region Provincias
        public ServiceResult ListarProvincias(bool? pvin_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _provinciasRepository.List(pvin_EsAduana);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }
        public ServiceResult ProvinciasPorPaises(int pais_Id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _provinciasRepository.ProvinciasPorPaises(pais_Id);
                return result.Ok(map);               
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ProvinciasPorPaisesYesAduana (int pais_Id, bool pvin_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var map = _provinciasRepository.ProvinciasPorPaisesYesAduana(pais_Id, pvin_EsAduana);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarProvincias(tbProvincias item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _provinciasRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarProvincias(tbProvincias item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _provinciasRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }



        public ServiceResult EliminarProvincias(tbProvincias item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _provinciasRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        #endregion

        #region Proveedores

        public ServiceResult ListarProveedores()
        {
            var result = new ServiceResult();
            try
            {
                var list = _proveedoresRepository.List();
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }
        
        public ServiceResult InsertarProveedores(tbProveedores item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _proveedoresRepository.Insert(item);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult ActualizarProveedores(tbProveedores item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _proveedoresRepository.Update(item);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult EliminarProveedores(tbProveedores item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _proveedoresRepository.Delete(item);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }

        }
        #endregion

        #region UnidadMedidas

        public ServiceResult ListarUnidadMedidas(bool? unme_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _unidadMedidasRepository.List(unme_EsAduana);
                return result.Ok(list);
            }
            catch (Exception e)
            {
                return result.Error(e.Message);
            }
        }

        public ServiceResult InsertarUnidadMedidas(tbUnidadMedidas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _unidadMedidasRepository.Insert(item);
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

        public ServiceResult ActualizarUnidadMedidas(tbUnidadMedidas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _unidadMedidasRepository.Update(item);
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

        public ServiceResult EliminarUnidadMedidas(tbUnidadMedidas item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _unidadMedidasRepository.Delete(item);
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
    }
}

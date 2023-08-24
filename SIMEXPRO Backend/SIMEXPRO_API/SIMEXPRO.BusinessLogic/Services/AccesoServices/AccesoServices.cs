
using SIMEXPRO.DataAccess;
using SIMEXPRO.DataAccess.Repositories.Acce;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.BussinessLogic.Services.AccesoServices
{
    public class AccesoServices
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly RolesPorPantallaRepository _rolesPorPantallaRepository;
        private readonly RolesRepository _rolesRepository;
        private readonly PantallasRepository _pantallasRepository;
        private readonly UsuariosHistorialRepository _usuariosHistorialRepository;

        public AccesoServices(PantallasRepository pantallasRepository, RolesRepository rolesRepository, RolesPorPantallaRepository rolesPorPantallaRepository, UsuariosRepository usuariosRepository, UsuariosHistorialRepository usuariosHistorialRepository)
        {
            _usuariosRepository = usuariosRepository;
            _rolesPorPantallaRepository = rolesPorPantallaRepository;
            _rolesRepository = rolesRepository;
            _pantallasRepository = pantallasRepository;
            _usuariosHistorialRepository = usuariosHistorialRepository;
        }

        #region Usuarios Historial
        #endregion

        #region Usuarios

        public ServiceResult IniciarSesion(tbUsuarios item)
        {
            var resultado = new ServiceResult();
            try
            {
                var usuario = _usuariosRepository.Login(item);

                if (usuario.usua_Nombre == null)
                    return resultado.Forbidden("El usuario o contraseña son incorrectos");
                else
                    return resultado.Ok(usuario);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult UsuarioCorreo(string usua_Nombre)
        {
            var resultado = new ServiceResult();
            try
            {
                var correo = _usuariosRepository.UsuarioCorreo(usua_Nombre);

                if (correo.MessageStatus == null)
                    return resultado.NotFound("El usuario no está disponible");
                else
                    return resultado.Ok(correo);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult CambiarContrasenia(tbUsuarios item)
        {
            var resultado = new ServiceResult();
            try
            {
                var correo = _usuariosRepository.CambiarContrasenia(item);

                if (correo.MessageStatus == "1")
                    return resultado.Ok("La contraseña ha sido actualizada");
                else
                    return resultado.Error(correo);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult ListarUsuarios(bool? empl_EsAduana)
        {

            var resultado = new ServiceResult();

            try
            {
                var list = _usuariosRepository.List(empl_EsAduana);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }

        }

        public ServiceResult InsertarUsuario(tbUsuarios item)
        {

            var resultado = new ServiceResult();

            try
            {
                var list = _usuariosRepository.Insert(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarUsuario(tbUsuarios item)
        {

            var resultado = new ServiceResult();

            try
            {
                var list = _usuariosRepository.Update(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }

        }


        public ServiceResult ActivarEstadoUsuario(tbUsuarios item)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _usuariosRepository.ActivarEstado(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }




        public ServiceResult DeleteUsuario(tbUsuarios item)
        {

            var resultado = new ServiceResult();
            try
            {
                var list = _usuariosRepository.Delete(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult CambiarPerfilUsuario(tbUsuarios item)
        {

            var resultado = new ServiceResult();

            try
            {
                var list = _usuariosRepository.CambiarPerfil(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }

            #endregion

            #region Roles Por Pantalla
            public ServiceResult Pantallas_Por_Rol(tbRolesXPantallas item)
        {
            var resultado = new ServiceResult();

            try
            {
                var list = _rolesPorPantallaRepository.Lista(item);
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {

                return resultado.Error(ex.Message);
            }
        }
        public ServiceResult PantallasPorRoleView(tbRolesXPantallas item)
        {
            var resultado = new ServiceResult();
            try
            {
                var list = _rolesPorPantallaRepository.List();
                return resultado.Ok(list);
            }
            catch (Exception ex)
            {

                return resultado.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRolxPantalla(tbRolesXPantallas item)
        {
            var resultado = new ServiceResult();
            try
            {
                var respuesta = _rolesPorPantallaRepository.Insert(item);
                return resultado.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        public ServiceResult ActualizarRolxPantalla(tbRolesXPantallas item)
        {
            var resultado = new ServiceResult();
            try
            {
                var respuesta = _rolesPorPantallaRepository.Update(item);
                return resultado.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);
            }
        }
        public ServiceResult DeleteRolxPantalla(tbRolesXPantallas item)
        {
            var resultado = new ServiceResult();
            try
            {
                var respuesta = _rolesPorPantallaRepository.Delete(item);
                return resultado.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return resultado.Error(ex.Message);

            }
        }
        public ServiceResult DibujarMenu(int role_Id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _rolesPorPantallaRepository.DibujarMenu(role_Id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult DibujadoDeMenu()
        {
            var result = new ServiceResult();
            try
            {
                var map = _rolesPorPantallaRepository.DibujadoDeMenu();
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Roles
        public ServiceResult ListarRoles(bool? role_Aduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _rolesRepository.List(role_Aduana);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _rolesRepository.Insert(item);
                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ActualizarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _rolesRepository.Update(item);
                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
              
                return result.Error(ex.Message);
            }
        }
        public ServiceResult DeleteRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var respuesta = _rolesRepository.Delete(item);
                return result.Ok(respuesta);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion


        #region Pantallas

        public ServiceResult ListarPantallas(bool? pant_EsAduana)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pantallasRepository.List(pant_EsAduana);
                
                return result.Ok(list);
            }
            catch (Exception ex)
            {

                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Login
        //public ServiceResult ValidarLogin(tbUsuarios item)
        //{
        //    var resultado = new ServiceResult();

        //    try
        //    {
        //        var usuario = _usuariosRepository.ValidarLogin(item);
        //        return resultado.Ok(usuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        return resultado.Error(ex.Message);
        //    }
        //}


        //public ServiceResult CambiaContra(tbUsuarios item)
        //{
        //    var result = new ServiceResult();
        //    try
        //    {
        //        if (item.usua_Usuario != "")
        //        {
        //            var map = _usuariosRepository.CambiaContra(item);
        //            if (map.MessageStatus != "1")
        //            {
        //                return result.Ok(map);
        //            }
        //            else
        //            {
        //                
        //                return result.Error(map);
        //            }
        //        }
        //        else
        //        {
        //            return result.SetMessage("La solicitud contiene sintaxis erronea", ServiceResultType.BadRecuest);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return result.Error(ex.Message);
        //    }

        //}

      
        #endregion*/
    }
}

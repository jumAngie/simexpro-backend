using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Acce
{
    public class UsuariosRepository : IRepository<tbUsuarios>
    {
        public tbUsuarios Login(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@usua_Nombre", item.usua_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Contrasenia", item.usua_Contrasenia, DbType.String, ParameterDirection.Input);

            var resultado = db.QueryFirst<tbUsuarios>(ScriptsDataBase.IniciarSesion, parametros, commandType: CommandType.StoredProcedure);
            return resultado;
        }

        public RequestStatus UsuarioCorreo(string usua_Nombre)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            RequestStatus result = new RequestStatus();

            parametros.Add("@usua_Nombre", usua_Nombre, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.CorreoSegunUsuario, parametros, commandType: CommandType.StoredProcedure);

            result.MessageStatus = respuesta;

            return result;
        }

        public RequestStatus CambiarContrasenia(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            RequestStatus result = new RequestStatus();

            parametros.Add("@usua_Nombre", item.usua_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Contrasenia", item.usua_Contrasenia, DbType.String, ParameterDirection.Input);


            var respuesta = db.QueryFirst<string>(ScriptsDataBase.CambiarContrasenia, parametros, commandType: CommandType.StoredProcedure);

            result.MessageStatus = respuesta;

            return result;
        }

        public RequestStatus Delete(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Id", item.usua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaEliminacion ", item.usua_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarUsuarios, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbUsuarios Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Nombre", item.usua_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Contrasenia", item.usua_Contrasenia, DbType.String, ParameterDirection.Input);
            //parametros.Add("@usua_Correo", item.usua_Correo, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_esAduana", item.usua_esAduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_Image", item.usua_Image, DbType.String, ParameterDirection.Input);
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_EsAdmin", item.usua_EsAdmin, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaCreacion ", item.usua_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarUsuarios, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbUsuarios> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbUsuarios>(ScriptsDataBase.ListarUsuarios, null, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<tbUsuarios> List(bool? empl_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@empl_EsAduana", empl_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbUsuarios>(ScriptsDataBase.ListarUsuarios, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Id", item.usua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_Contrasenia", item.usua_Contrasenia, DbType.String, ParameterDirection.Input);
            //parametros.Add("@usua_Correo", item.usua_Correo, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_Image", item.usua_Image, DbType.String, ParameterDirection.Input);
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_EsAdmin", item.usua_EsAdmin, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaModificacion", item.usua_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarUsuarios, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus ActivarEstado(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Id", item.usua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioActivacion", item.usua_UsuarioActivacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaActivacion", item.usua_FechaActivacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.ActivarEstadoUsuarios, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus CambiarPerfil(tbUsuarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Id", item.usua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_Image", item.usua_Image, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaModificacion", item.usua_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.CambiarFotoPerfil, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

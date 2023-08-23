using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Prod
{
    public class ClientesRepository : IRepository<tbClientes>
    {
        public RequestStatus Delete(tbClientes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Id",                  item.clie_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@clie_FechaEliminacion",    item.clie_FechaEliminacion,     DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarClientes, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbClientes Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbClientes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Nombre_O_Razon_Social",   item.clie_Nombre_O_Razon_Social,    DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Direccion",               item.clie_Direccion,                DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_RTN",                     item.clie_RTN,                      DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Nombre_Contacto",         item.clie_Nombre_Contacto,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Numero_Contacto",         item.clie_Numero_Contacto,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Correo_Electronico",      item.clie_Correo_Electronico,       DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_FAX",                     item.clie_FAX,                      DbType.String,      ParameterDirection.Input);
            parametros.Add("@pvin_Id",                      item.pvin_Id,                       DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",         item.usua_UsuarioCreacion,          DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@clie_FechaCreacion",           item.clie_FechaCreacion,            DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarClientes, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbClientes> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbClientes>(ScriptsDataBase.ListarClientes, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbClientes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Id",                      item.clie_Id,                       DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@clie_Nombre_O_Razon_Social",   item.clie_Nombre_O_Razon_Social,    DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Direccion",               item.clie_Direccion,                DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_RTN",                     item.clie_RTN,                      DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Nombre_Contacto",         item.clie_Nombre_Contacto,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Numero_Contacto",         item.clie_Numero_Contacto,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_Correo_Electronico",      item.clie_Correo_Electronico,       DbType.String,      ParameterDirection.Input);
            parametros.Add("@clie_FAX",                     item.clie_FAX,                      DbType.String,      ParameterDirection.Input);
            parametros.Add("@pvin_Id",                      item.pvin_Id,                       DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion",     item.usua_UsuarioModificacion,      DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@clie_FechaModificacion",       item.clie_FechaModificacion,        DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarClientes, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus ActivarEstado(tbClientes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Id",                      item.clie_Id,                      DbType.Int32,         ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion",     item.usua_UsuarioModificacion,     DbType.Int32,         ParameterDirection.Input);
            parametros.Add("@clie_FechaModificacion",       item.clie_FechaModificacion,       DbType.DateTime,      ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.ActivarEstadoClientes, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SIMEXPRO.DataAccess.Repositories.Acce
{
    public class RolesRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(tbRoles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_FechaEliminacion", item.role_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarRoles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbRoles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbRoles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Descripcion", item.role_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@pant_Ids", item.pant_Ids, DbType.String, ParameterDirection.Input);
            parametros.Add("@role_Aduana", item.role_Aduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_FechaCreacion", item.role_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarRoles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbRoles> List(bool? role_Aduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_Aduana", role_Aduana, DbType.Boolean, ParameterDirection.Input);

            return db.Query<tbRoles>(ScriptsDataBase.ListarRoles, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<tbRoles> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbRoles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_Descripcion", item.role_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@pant_Ids", item.pant_Ids, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@roleFechaModificacion", item.role_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarRoles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

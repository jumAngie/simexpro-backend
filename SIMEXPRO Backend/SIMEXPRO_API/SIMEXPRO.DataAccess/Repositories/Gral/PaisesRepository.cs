using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Gral
{
    public class PaisesRepository : IRepository<tbPaises>
    {
        public RequestStatus Delete(tbPaises item)
        {
            throw new NotImplementedException();
        }

        public tbPaises Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPaises item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pais_Codigo", item.pais_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pais_Nombre", item.pais_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@pais_EsAduana", item.pais_EsAduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_FechaCreacion", item.pais_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPaises, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPaises> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbPaises>(ScriptsDataBase.ListarPaises, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbPaises> List(bool? pais_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pais_EsAduana", pais_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbPaises>(ScriptsDataBase.ListarPaises, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbPaises item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pais_Id", item.pais_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_Codigo", item.pais_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pais_Nombre", item.pais_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_FechaModificacion", item.pais_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPaises, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

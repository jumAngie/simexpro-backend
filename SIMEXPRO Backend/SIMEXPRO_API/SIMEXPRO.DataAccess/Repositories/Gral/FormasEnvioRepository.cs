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
    public class FormasEnvioRepository : IRepository<tbFormas_Envio>
    {
        public RequestStatus Delete(tbFormas_Envio item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@foen_Id", item.foen_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@foen_FechaEliminacion", item.foen_FechaEliminacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarFormasEnvio, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbFormas_Envio Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFormas_Envio item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@foen_Codigo", item.foen_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@foen_Descripcion", item.foen_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@foen_FechaCreacion", item.foen_FechaCreacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarFormasEnvio, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus= answer;
            return result;
        }

        public IEnumerable<tbFormas_Envio> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbFormas_Envio>(ScriptsDataBase.ListarFormasEnvio, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbFormas_Envio item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@foen_Id", item.foen_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@foen_Codigo", item.foen_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@foen_Descripcion", item.foen_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@foen_FechaModificacion", item.foen_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarFormasEnvio, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }



    }
}

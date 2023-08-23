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
    public class ModelosMaquinaRepository : IRepository<tbModelosMaquina>
    {
        public RequestStatus Delete(tbModelosMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mmaq_Id", item.mmaq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_FechaEliminacion", item.mmaq_FechaEliminacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarModelosMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbModelosMaquina Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbModelosMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mmaq_Nombre", item.mmaq_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@marq_Id", item.marq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@func_Id", item.func_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_Imagen", item.mmaq_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_FechaCreacion", item.mmaq_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarModelosMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbModelosMaquina> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbModelosMaquina>(ScriptsDataBase.ListarModelosMaquina, null, commandType: CommandType.StoredProcedure); ;
        }

        public RequestStatus Update(tbModelosMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mmaq_Id", item.mmaq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_Nombre", item.mmaq_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@marq_Id", item.marq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@func_Id", item.func_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_Imagen", item.mmaq_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_FechaModificacion", item.mmaq_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarModelosMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

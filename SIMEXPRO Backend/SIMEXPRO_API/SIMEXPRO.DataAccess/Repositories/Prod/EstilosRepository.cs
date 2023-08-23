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
    public class EstilosRepository : IRepository<tbEstilos>
    {
        public RequestStatus Delete(tbEstilos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@esti_Id", item.esti_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_FechaEliminacion", item.esti_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarEstilos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbEstilos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstilos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@esti_Descripcion", item.esti_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_FechaCreacion", item.esti_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
       
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarEstilos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbEstilos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbEstilos>(ScriptsDataBase.ListarEstilos, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbEstilos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@esti_Id", item.esti_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_Descripcion", item.esti_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_FechaModificacion", item.esti_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarEstilos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

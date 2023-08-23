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
    public class ReporteModuloDiaDetalleRepository : IRepository<tbReporteModuloDiaDetalle>
    {
       

        public RequestStatus Delete(tbReporteModuloDiaDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@rdet_Id", item.rdet_Id, DbType.Int32, ParameterDirection.Input);
              
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarReporteModuloDiaDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbReporteModuloDiaDetalle Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbReporteModuloDiaDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@remo_Id", item.remo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rdet_TotalDia", item.rdet_TotalDia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rdet_TotalDanado", item.rdet_TotalDanado, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarReporteModuloDiaDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbReporteModuloDiaDetalle> List(int remo_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@remo_Id",remo_Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbReporteModuloDiaDetalle>(ScriptsDataBase.ListarReporteModuloDiaDetalle, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbReporteModuloDiaDetalle> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbReporteModuloDiaDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@rdet_Id", item.rdet_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_Id", item.remo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rdet_TotalDia", item.rdet_TotalDia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rdet_TotalDanado", item.rdet_TotalDanado, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarReporteModuloDiaDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class ReporteModuloDiaRepository : IRepository<tbReporteModuloDia>
    {
        public RequestStatus Delete(tbReporteModuloDia item)
        {
            throw new NotImplementedException();
        }

        public tbReporteModuloDia Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbReporteModuloDia item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_Fecha", item.remo_Fecha, DbType.Date, ParameterDirection.Input);
            parametros.Add("@remo_TotalDia", item.remo_TotalDia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_TotalDanado", item.remo_TotalDanado, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_FechaCreacion", item.remo_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarReporteModuloDia, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbReporteModuloDia> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbReporteModuloDia>(ScriptsDataBase.ListarReporteModuloDia, null, commandType: CommandType.StoredProcedure);
        }





        public RequestStatus Update(tbReporteModuloDia item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@remo_Id", item.remo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_Fecha", item.remo_Fecha, DbType.Date, ParameterDirection.Input);
            parametros.Add("@remo_TotalDia", item.remo_TotalDia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_TotalDanado", item.remo_TotalDanado, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@remo_FechaModificacion", item.remo_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarReporteModuloDia, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

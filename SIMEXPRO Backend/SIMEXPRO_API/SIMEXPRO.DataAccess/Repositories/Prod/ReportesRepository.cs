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
    public class ReportesRepository
    {
        public IEnumerable<tbReportes> MaquinasTiempo(tbReportes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@maqu_Id", item.maqu_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbReportes>(ScriptsDataBase.MaquinasTiempos, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbReportes> ModuloProduccion (tbReportes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fecha_inicio", item.fecha_inicio, DbType.Date, ParameterDirection.Input);   
            parametros.Add("@fecha_fin", item.fecha_fin, DbType.Date, ParameterDirection.Input);   
            var answer = db.Query<tbReportes>(ScriptsDataBase.ModuloProduccion, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
            public IEnumerable<tbReportes> PedidosCliente(tbReportes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters(); 
            parametros.Add("@clie_Id", item.clie_Id, DbType.Int32, ParameterDirection.Input);   
            var answer = db.Query<tbReportes>(ScriptsDataBase.PedidosCliente, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }



    }
}

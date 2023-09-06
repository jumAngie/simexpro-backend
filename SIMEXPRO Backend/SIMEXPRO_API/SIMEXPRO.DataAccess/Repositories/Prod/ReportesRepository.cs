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



    }
}

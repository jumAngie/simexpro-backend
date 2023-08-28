using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Adua
{
    public class AduanaGraficasRepository
    {
        public IEnumerable<tbGraficas> ExportadoresPorPais_CantidadPorcentaje()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_ExportadoresPorPais_CantidadPorcentaje, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
    }
}

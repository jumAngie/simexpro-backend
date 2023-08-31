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

        public IEnumerable<tbGraficas> EstadosMercancias_CantidadPorcentaje()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_EstadosMercancias_CantidadPorcentaje, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> AduanasIngreso_CantidadPorcentaje()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_AduanasIngreso_CantidadPorcentaje, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbGraficas> Importaciones_Contador_Anio()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_Importaciones_Contador_Anio, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> Importaciones_Contador_Mes()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_Importaciones_Contador_Mes, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbGraficas> Importaciones_Contador_Semana()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Adua_UDP_Importaciones_Contador_Semana, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> Importaciones_Semana()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Importaciones_Semana, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> Importaciones_Mes()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Importaciones_Mes, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> Importaciones_Anio()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.Importaciones_Anio, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbGraficas> RegimenesAduaneros_CantidadPorcentaje()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.RegimenesAduaneros_CantidadPorcentaje, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

    }
}

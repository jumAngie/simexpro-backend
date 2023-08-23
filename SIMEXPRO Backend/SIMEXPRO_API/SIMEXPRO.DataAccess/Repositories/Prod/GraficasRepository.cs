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
    public class GraficasRepository
    {
        public IEnumerable<tbGraficas> Avance_Orden_Compra (tbGraficas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_AvanceOrdenCompraPorID, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
 
        public IEnumerable<tbGraficas> TotalOrdenesCompraAnual()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_TotalOrdenesCompraAnual, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbGraficas> TotalOrdenesCompraMensual()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_TotalOrdenesCompraMensual, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbGraficas> TotalOrdenesCompraDiario()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_TotalOrdenesCompraDiario, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbGraficas> ContadorOrdenesCompraPorEstado()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_ContadorOrdenesCompraPorEstado, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> ContadorOrdenesCompraPorEstado_UltimaSemana()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_ContadorOrdenesCompraPorEstado_UltimaSemana, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> VentasSemanales()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_VentasSemanales, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> VentasMensuales()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_VentasMensuales, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> VentasAnuales()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_VentasAnuales, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> OrdenenesEntregadasPendientes_Anual()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_OrdenenesEntregadasPendientes_Anual, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> OrdenenesEntregadasPendientes_Mensual()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_OrdenenesEntregadasPendientes_Mensual, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> OrdenenesEntregadasPendientes_Semanal()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_OrdenenesEntregadasPendientes_Semanal, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> PrendasPedidas(tbGraficas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@esti_Id", item.esti_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_PrendasPedidas, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> ClientesProductivos()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_ClientesProductivos, null, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbGraficas> ProductividadModulos()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            var answer = db.Query<tbGraficas>(ScriptsDataBase.GR_ProductividadModulos, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
    }
}

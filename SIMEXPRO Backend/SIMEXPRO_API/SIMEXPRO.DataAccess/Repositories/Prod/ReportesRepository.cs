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

        public IEnumerable<tbReportes> PlanificacionPO(int orco_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", Convert.ToInt32(orco_Id), DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbReportes>(ScriptsDataBase.PlanificacionPO, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbReportes> CostosMaterialesNoBrindados(tbReportes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@mate_FechaInicio", item.mate_FechaInicio, DbType.Date, ParameterDirection.Input);
            parametros.Add("@mate_FechaLimite", item.mate_FechaLimite, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbReportes>(ScriptsDataBase.CostosMaterialesNoBrindados, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbReportes> Consumo_Materiales(tbReportes item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fecha_inicio", item.fecha_inicio, DbType.Date, ParameterDirection.Input);
            parametros.Add("@fecha_fin", item.fecha_fin, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbReportes>(ScriptsDataBase.Consumo_Materiales, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbMaquinas> MaquinasUso(tbMaquinas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbMaquinas>(ScriptsDataBase.MaquinasUso, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbOrdenCompra> OrdenesCompraFecha(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add ("@FechaInicio", item.orco_FechaEmision, DbType.Date, ParameterDirection.Input);
            parametros.Add("@FechaFin", item.orco_FechaLimite, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbOrdenCompra>(ScriptsDataBase.OrdenesCompraFecha, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbMateriales> Inventario(tbMateriales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add ("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbMateriales>(ScriptsDataBase.Inventario, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }


        public IEnumerable<tbDuca> Importaciones(DateTime FechaI, DateTime FechaF)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@FechaInicio", FechaI, DbType.Date, ParameterDirection.Input);
            parametros.Add("@FechaFin", FechaF, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbDuca>(ScriptsDataBase.Importaciones, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<VW_tbDeclaraciones_ValorCompleto> DevasPendientes(DateTime FechaI, DateTime FechaF)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@FechaInicio", FechaI, DbType.Date, ParameterDirection.Input);
            parametros.Add("@FechaFin", FechaF, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<VW_tbDeclaraciones_ValorCompleto>(ScriptsDataBase.DevaPendiente, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbOrdenCompra> MateriasDePO(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add ("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbOrdenCompra>(ScriptsDataBase.MateriasDePO, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        
        public IEnumerable<tbArea> ProduccionAreas(tbArea item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add ("@fechaInicio", item.fechaInicio, DbType.Date, ParameterDirection.Input);
            parametros.Add ("@fechaFin", item.fechaFin, DbType.Date, ParameterDirection.Input);
            parametros.Add ("@tipa_Id", item.tipa_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbArea>(ScriptsDataBase.ProduccionAreas, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbPedidosOrden> MaterialesIngreso(tbPedidosOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add ("@fechaInicio", item.fechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add ("@fechaFin", item.fechaFin, DbType.DateTime, ParameterDirection.Input);
            var answer = db.Query<tbPedidosOrden>(ScriptsDataBase.MaterialesIngreso, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbPersonaJuridica> Contratos_Adhesion_PJ(DateTime fechaInicio, DateTime fechaFin)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fecha_inicio", fechaInicio, DbType.Date, ParameterDirection.Input);
            parametros.Add("@fecha_fin", fechaFin, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbPersonaJuridica>(ScriptsDataBase.Contrato_PJ, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbComercianteIndividual> Contratos_Adhesion_CI(DateTime fechaInicio, DateTime fechaFin)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fecha_inicio", fechaInicio, DbType.Date, ParameterDirection.Input);
            parametros.Add("@fecha_fin", fechaFin, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbComercianteIndividual>(ScriptsDataBase.Contrato_CI, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

        public IEnumerable<tbPersonaNatural> Contratos_Adhesion_PN(DateTime fechaInicio, DateTime fechaFin)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fecha_inicio", fechaInicio, DbType.Date, ParameterDirection.Input);
            parametros.Add("@fecha_fin", fechaFin, DbType.Date, ParameterDirection.Input);
            var answer = db.Query<tbPersonaNatural>(ScriptsDataBase.Contrato_PN, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }

    }
}

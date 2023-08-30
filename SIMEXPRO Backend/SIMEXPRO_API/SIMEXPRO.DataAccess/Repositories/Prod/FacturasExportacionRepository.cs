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
    public class FacturasExportacionRepository : IRepository<tbFacturasExportacion>
    {
        public RequestStatus Delete(tbFacturasExportacion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@faex_Id", item.faex_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarFacturasExportacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbFacturasExportacion Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFacturasExportacion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parametros.Add("@faex_Fecha", item.faex_Fecha, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@faex_Total", item.faex_Total, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@faex_FechaCreacion", item.faex_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarFacturasExportacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbFacturasExportacion> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbFacturasExportacion>(ScriptsDataBase.ListarFacturasExportacion, null, commandType: CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbFacturasExportacion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@faex_Id", item.faex_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parametros.Add("@faex_Fecha", item.faex_Fecha, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@faex_Total", item.faex_Total, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@faex_FechaModificacion", item.faex_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarFacturasExportacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus Finalizar(tbFacturasExportacion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@faex_Id", item.faex_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.FinalizarFacturasExportacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public IEnumerable<tbFacturasExportacion> OrdenesCompraDDL()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbFacturasExportacion>(ScriptsDataBase.OrdenesCompraDDL, null, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<tbFacturasExportacion> DUCAsDDL()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbFacturasExportacion>(ScriptsDataBase.DUCAsDDL, null, commandType: CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus ComprobarNoDUCA(tbFacturasExportacion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.ComprobarNoDUCA, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

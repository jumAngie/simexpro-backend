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
    public class PODetallePorPedidoOrdenDetalleRepository : IRepository<tbPODetallePorPedidoOrdenDetalle>
    {
        public RequestStatus Delete(tbPODetallePorPedidoOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ocpo_Id", item.ocpo_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarPedidosOrdenDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbPODetallePorPedidoOrdenDetalle Find(int? id)
        {
            throw new NotImplementedException();
        }
        public RequestStatus Insert(tbPODetallePorPedidoOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ocpo_FechaCreacion", item.ocpo_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPODetallePorPedidoOrdenDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
        public IEnumerable<tbPODetallePorPedidoOrdenDetalle> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbPODetallePorPedidoOrdenDetalle>(ScriptsDataBase.ListarPODetallePorPedidoOrdenDetalle, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
        public IEnumerable<tbPODetallePorPedidoOrdenDetalle> ListxProd_Id(int  prod_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", prod_Id, DbType.Int32, ParameterDirection.Input);
            var result = db.Query<tbPODetallePorPedidoOrdenDetalle>(ScriptsDataBase.ListarPODetallePorPedidoOrdenDetalle, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbPODetallePorPedidoOrdenDetalle item)
        {
            throw new NotImplementedException();
        }
    }
}

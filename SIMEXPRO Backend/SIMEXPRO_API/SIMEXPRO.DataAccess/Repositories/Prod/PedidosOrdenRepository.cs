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
    public class PedidosOrdenRepository : IRepository<tbPedidosOrden>
    {
        public RequestStatus Delete(tbPedidosOrden item)
        {
            throw new NotImplementedException();
        }

        public tbPedidosOrden Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPedidosOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id", item.prov_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peor_DireccionExacta", item.peor_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@peor_FechaEntrada", item.peor_FechaEntrada, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@peor_Obsevaciones", item.peor_Obsevaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@peor_Impuestos", item.peor_Impuestos, DbType.Decimal, ParameterDirection.Input);
            //parametros.Add("@peor_DadoCliente", item.peor_DadoCliente, DbType.Boolean, ParameterDirection.Input);
            //parametros.Add("@peor_Est", item.peor_Est, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peor_FechaCreacion", item.peor_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPedidosOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosOrden> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbPedidosOrden>(ScriptsDataBase.ListarPedidosOrden, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbPedidosOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@peor_Id", item.peor_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_Id", item.prov_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peor_DireccionExacta", item.peor_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@peor_FechaEntrada", item.peor_FechaEntrada, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@peor_Obsevaciones", item.peor_Obsevaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@peor_Impuestos", item.peor_Impuestos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peor_FechaModificacion", item.peor_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPedidosOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus FinalizarpedidoOrden(tbPedidosOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@peor_Id", item.peor_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.FinalizarPedidosOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

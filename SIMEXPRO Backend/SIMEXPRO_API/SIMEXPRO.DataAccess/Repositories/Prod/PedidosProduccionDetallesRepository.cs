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
    public class PedidosProduccionDetallesRepository : IRepository<tbPedidosProduccionDetalles>
    {
        public RequestStatus Delete(tbPedidosProduccionDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ppde_Id", item.ppde_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarPedidosProduccionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbPedidosProduccionDetalles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPedidosProduccionDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@lote_Id", item.lote_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppde_Cantidad", item.ppde_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppde_FechaCreacion", item.ppde_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPedidosProduccionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosProduccionDetalles> List(int ppro_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@ppro_Id", ppro_Id, DbType.Int32, ParameterDirection.Input);

            var result = db.Query<tbPedidosProduccionDetalles>(ScriptsDataBase.ListarPedidosProduccionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<tbPedidosProduccionDetalles> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbPedidosProduccionDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ppde_Id", item.ppde_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@lote_Id", item.lote_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppde_Cantidad", item.ppde_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppde_FechaModificacion", item.ppde_FechaModificacion, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPedidosProduccionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosProduccionDetalles> Filter(int ppro_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@ppro_Id", ppro_Id, DbType.Int32, ParameterDirection.Input);

            var result = db.Query<tbPedidosProduccionDetalles>(ScriptsDataBase.FiltrarPedidosProduccionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}

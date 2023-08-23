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
    public class PedidosProduccionRepository : IRepository<tbPedidosProduccion>
    {
        public RequestStatus Delete(tbPedidosProduccion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarPedidosProduccion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
        public tbPedidosProduccion Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPedidosProduccion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppro_Fecha", item.ppro_Fecha, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ppro_Estados", item.ppro_Estados, DbType.String, ParameterDirection.Input);
            parametros.Add("@ppr_Observaciones", item.ppro_Observaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@lote_Id", item.lote_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppde_Cantidad", item.ppde_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppro_FechaCreacion", item.ppro_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPedidosProduccion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosProduccion> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbPedidosProduccion>(ScriptsDataBase.ListarPedidosProduccion, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbPedidosProduccion item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppro_Fecha", item.ppro_Fecha, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ppro_Estados", item.ppro_Estados, DbType.String, ParameterDirection.Input);
            parametros.Add("@ppr_Observaciones", item.ppro_Observaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ppro_FechaModificacion", item.ppro_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPedidosProduccion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

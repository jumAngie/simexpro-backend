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
    public class PedidosOrdenDetallesRepository : IRepository<tbPedidosOrdenDetalle>
    {
        public RequestStatus Delete(tbPedidosOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarDetalleConDuca, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

       
        public tbPedidosOrdenDetalle Find(int? id)
        {
            throw new NotImplementedException();
        }


        public RequestStatus Insert(tbPedidosOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pedi_Id", item.pedi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Cantidad", item.prod_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Precio", item.prod_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_FechaCreacion", item.prod_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPedidosOrdenDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosOrdenDetalle> List(int? pedi_Id)
        {

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@pedi_Id", pedi_Id, DbType.Int32, ParameterDirection.Input);

            var result = db.Query<tbPedidosOrdenDetalle>(ScriptsDataBase.ListarPedidosOrdenDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<tbPedidosOrdenDetalle> Find(int prod_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", prod_Id, DbType.Int32, ParameterDirection.Input);

            return db.Query<tbPedidosOrdenDetalle>(ScriptsDataBase.PedidosOrdenDetallesFind, parametros, commandType: CommandType.StoredProcedure);
        }
        public RequestStatus Update(tbPedidosOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pedi_Id", item.pedi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Cantidad", item.prod_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Precio", item.prod_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_FechaModificacion", item.prod_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPedidosOrdenDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPedidosOrdenDetalle> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus InsertItemsPedidosOrden(tbPedidosOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@peor_Id", item.pedi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Descripcion", item.mate_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@prod_Cantidad", item.prod_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Precio", item.prod_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarItemsPedidosOrdenDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

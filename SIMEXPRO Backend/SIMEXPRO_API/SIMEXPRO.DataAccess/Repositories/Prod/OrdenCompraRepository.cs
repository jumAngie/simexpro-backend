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
    public class OrdenCompraRepository : IRepository<tbOrdenCompra>
    {

        public RequestStatus Delete(tbOrdenCompra item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus EliminarOrdenCompra(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarOrdenCompra, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbOrdenCompra Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@orco_IdCliente", item.orco_IdCliente, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_FechaEmision", item.orco_FechaEmision, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_FechaLimite", item.orco_FechaLimite, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_MetodoPago", item.orco_MetodoPago, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_Materiales", item.orco_Materiales, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@orco_IdEmbalaje", item.orco_IdEmbalaje, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_EstadoOrdenCompra", item.orco_EstadoOrdenCompra, DbType.String, ParameterDirection.Input);
            parametros.Add("@orco_DireccionEntrega", item.orco_DireccionEntrega, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_FechaCreacion", item.orco_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_Codigo", item.orco_Codigo, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarOrdenCompra, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbOrdenCompra> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbOrdenCompra>(ScriptsDataBase.ListarOrdenCompra, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_IdCliente", item.orco_IdCliente, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_FechaEmision", item.orco_FechaEmision, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_FechaLimite", item.orco_FechaLimite, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@orco_MetodoPago", item.orco_MetodoPago, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_Materiales", item.orco_Materiales, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@orco_IdEmbalaje", item.orco_IdEmbalaje, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_EstadoOrdenCompra", item.orco_EstadoOrdenCompra, DbType.String, ParameterDirection.Input);
            parametros.Add("@orco_DireccionEntrega", item.orco_DireccionEntrega, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_FechaModificacion", item.orco_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarOrdenCompra, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbOrdenCompra> LineaTiempo(string orco_Codigo)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Codigo", orco_Codigo, DbType.String, ParameterDirection.Input);
           
            return db.Query<tbOrdenCompra>(ScriptsDataBase.ObtenerOrdenCompraPorIdParaLineaTiempo, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbOrdenCompra> ExportData()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbOrdenCompra>(ScriptsDataBase.PO_ExportData, parametros, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus FinalizarOrdenCompra(tbOrdenCompra item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.FinalizarOrdenCompra, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

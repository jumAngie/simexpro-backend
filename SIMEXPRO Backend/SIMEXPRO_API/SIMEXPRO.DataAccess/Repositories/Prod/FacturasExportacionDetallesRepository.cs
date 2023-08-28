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
    public class FacturasExportacionDetallesRepository : IRepository<tbFacturasExportacionDetalles>
    {
        public RequestStatus Delete(tbFacturasExportacionDetalles item)
        {
            throw new NotImplementedException();
        }

        public tbFacturasExportacionDetalles Find(int? id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<tbFacturasExportacionDetalles> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFacturasExportacionDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@faex_Id", item.faex_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_Cajas", item.fede_Cajas, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_Cantidad", item.fede_Cantidad, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@fede_PrecioUnitario", item.fede_PrecioUnitario, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@fede_TotalDetalle", item.fede_TotalDetalle, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_FechaCreacion", item.fede_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarFacturasExportacionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public IEnumerable<tbFacturasExportacionDetalles> ListByID(int faex_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@faex_Id", faex_Id, DbType.Int32, ParameterDirection.Input);

            var result = db.Query<tbFacturasExportacionDetalles>(ScriptsDataBase.ListarFacturasExportacionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbFacturasExportacionDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@fede_Id", item.fede_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@faex_Id", item.faex_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_Cajas", item.fede_Cajas, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_Cantidad", item.fede_Cantidad, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@fede_PrecioUnitario", item.fede_PrecioUnitario, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@fede_TotalDetalle", item.fede_TotalDetalle, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fede_FechaModificacion", item.fede_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarFacturasExportacionDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

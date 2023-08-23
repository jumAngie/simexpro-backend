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
    public class ProcesoPorOrdenCompraDetalleRepository : IRepository<tbProcesoPorOrdenCompraDetalle>
    {
        public RequestStatus Delete(tbProcesoPorOrdenCompraDetalle item)
        {
            throw new NotImplementedException();
        }

        public tbProcesoPorOrdenCompraDetalle Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbProcesoPorOrdenCompraDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@proc_Id", item.proc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@poco_FechaCreacion", item.poco_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarProcesoPorOrdenCompraDetalle, parametros, commandType: System.Data.CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbProcesoPorOrdenCompraDetalle> Listar(int code_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", code_Id, DbType.Int32, ParameterDirection.Input);

            var result = db.Query<tbProcesoPorOrdenCompraDetalle>(ScriptsDataBase.ListarProcesoPorOrdenCompraDetalle, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<tbProcesoPorOrdenCompraDetalle> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbProcesoPorOrdenCompraDetalle item)
        {
            throw new NotImplementedException();
        }
    }
}

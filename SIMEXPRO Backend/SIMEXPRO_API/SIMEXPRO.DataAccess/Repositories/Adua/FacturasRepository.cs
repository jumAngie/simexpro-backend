using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Adua
{
    public class FacturasRepository : IRepository<tbFacturas>
    {
        public RequestStatus Delete(tbFacturas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@deva_Id", item.deva_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_Numero", item.fact_Numero, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_Fecha", item.fact_Fecha, DbType.Date, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fact_FechaCreacion", item.fact_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarFacturas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbFacturas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFacturas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fact_Numero", item.fact_Numero, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_Fecha", item.fact_Fecha, DbType.Date, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fact_FechaCreacion", item.fact_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarFacturas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus VerficarFactura (string fact_Numero)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@fact_Numero", fact_Numero, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.VerificarFacturas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbFacturas> List(int deva_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@deva_Id", deva_Id, DbType.String, ParameterDirection.Input);
            return db.Query<tbFacturas>(ScriptsDataBase.ListarFacturas, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbFacturas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbFacturas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@fact_Id", item.fact_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@deva_Id", item.deva_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_Numero", item.fact_Numero, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_Fecha", item.fact_Fecha, DbType.Date, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fact_FechaCreacion", item.fact_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarFacturas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

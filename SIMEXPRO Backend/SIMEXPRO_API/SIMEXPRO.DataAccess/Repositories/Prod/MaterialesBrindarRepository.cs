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
    public class MaterialesBrindarRepository : IRepository<tbMaterialesBrindar>
    {
        public RequestStatus Delete(tbMaterialesBrindar item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mabr_Id", item.mabr_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMaterialesBrindar, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbMaterialesBrindar Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMaterialesBrindar item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@unme_Id", item.unme_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mabr_Cantidad", item.mabr_Cantidad, DbType.Int32, ParameterDirection.Input);

            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mabr_FechaCreacion", item.mabr_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMaterialesBrindar, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMaterialesBrindar> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbMaterialesBrindar>(ScriptsDataBase.ListarMaterialesBrindar, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbMaterialesBrindar> List2(int code_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", code_Id, DbType.Int32, ParameterDirection.Input);
            var result = db.Query<tbMaterialesBrindar>(ScriptsDataBase.ListarMaterialesBrindarFiltrado, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbMaterialesBrindar item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mabr_Id", item.mabr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@unme_Id", item.unme_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mabr_Cantidad", item.mabr_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mabr_FechaModificacion", item.mabr_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMaterialesBrindar, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

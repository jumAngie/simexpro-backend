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
    public class ImpuestosporAracelRepository : IRepository<tbImpuestosPorArancel>
    {
        public RequestStatus Delete(tbImpuestosPorArancel item)
        {
            throw new NotImplementedException();
        }

        public tbImpuestosPorArancel Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbImpuestosPorArancel item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@impu_Id", item.@impu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_Id", item.@aran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@imar_FechaCreacion ", item.imar_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarImpuestosPorArancel, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbImpuestosPorArancel> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            return db.Query<tbImpuestosPorArancel>(ScriptsDataBase.ListarImpuestosPorArancel, null, commandType: CommandType.StoredProcedure);      
        }

        public RequestStatus Update(tbImpuestosPorArancel item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@imar_Id", item.imar_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@impu_Id", item.@impu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_Id", item.@aran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@imar_FechaCreacion ", item.imar_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarImpuestosPorArancel, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

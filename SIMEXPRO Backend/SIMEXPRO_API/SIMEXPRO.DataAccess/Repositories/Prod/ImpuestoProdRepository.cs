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
    public class ImpuestoProdRepository : IRepository<tbImpuestosProd>
    {
        public RequestStatus Delete(tbImpuestosProd item)
        {
            throw new NotImplementedException();
        }

        public tbImpuestosProd Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbImpuestosProd item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbImpuestosProd> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbImpuestosProd>(ScriptsDataBase.ListarImpuestosProd, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbImpuestosProd item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@impr_Id", item.impr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@impr_Valor", item.impr_Valor, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@impr_FechaModificacion", item.impr_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarImpuestosProd, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

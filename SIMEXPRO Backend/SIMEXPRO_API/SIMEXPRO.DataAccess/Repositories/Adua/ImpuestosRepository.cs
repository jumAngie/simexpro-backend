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
    public class ImpuestosRepository : IRepository<tbImpuestos>
    {
        public RequestStatus Delete(tbImpuestos item)
        {
            throw new NotImplementedException();
        }

        public tbImpuestos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbImpuestos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@aran_Codigo", item.aran_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@impu_Descripcion", item.impu_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@impu_Impuesto", item.impu_Impuesto, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@impu_FechaCreacion", item.impu_FechaCreacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarImpuestos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbImpuestos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbImpuestos>(ScriptsDataBase.ListarImpuestos, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbImpuestos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@impu_Id", item.impu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_Codigo", item.aran_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@impu_Descripcion", item.impu_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@impu_Impuesto", item.impu_Impuesto, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@impu_FechaModificacion", item.impu_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarImpuestos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus= answer;
            return result;
        }
    }
}

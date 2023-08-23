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
    public class CodigoImpuestoRepository : IRepository<tbCodigoImpuesto>
    {
        public RequestStatus Delete(tbCodigoImpuesto item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coim_Id", item.coim_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coim_FechaEliminacion", item.coim_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarCodigoImpuesto, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer.ToString();
            return result;
        }

        public tbCodigoImpuesto Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCodigoImpuesto item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coim_Descripcion", item.coim_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coim_FechaCreacion", item.coim_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarCodigoImpuesto, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer.ToString();
            return result;
        }

        public IEnumerable<tbCodigoImpuesto> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbCodigoImpuesto>(ScriptsDataBase.ListarCodigoImpuesto, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCodigoImpuesto item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coim_Id", item.coim_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coim_Descripcion", item.coim_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coim_FechaModificacion", item.coim_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<int>(ScriptsDataBase.EditarCodigoImpuesto, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer.ToString();
            return result;
        }
    }
}

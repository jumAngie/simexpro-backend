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
    public class CategoriasRepository : IRepository<tbCategoria>
    {
        public RequestStatus Delete(tbCategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@cate_Id",                  item.cate_Id,                   DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@cate_FechaEliminacion",    item.cate_FechaEliminacion,     DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarCategorias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbCategoria Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@cate_Descripcion",         item.cate_Descripcion,      DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",     item.usua_UsuarioCreacion,  DbType.Int32, ParameterDirection.Input);
            parametros.Add("@cate_FechaCreacion",       item.cate_FechaCreacion,    DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarCategorias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbCategoria> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbCategoria>(ScriptsDataBase.ListarCategorias, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@cate_Id",                  item.cate_Id,    DbType.String, ParameterDirection.Input);
            parametros.Add("@cate_Descripcion",         item.cate_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@cate_FechaModificacion",   item.cate_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarCategorias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

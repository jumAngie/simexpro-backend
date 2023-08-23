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
    public class SubCategoriasRepository : IRepository<tbSubcategoria>
    {


        public RequestStatus Delete(tbSubcategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@subc_Id", item.subc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@subc_FechaEliminacion", item.subc_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarSubCategoria, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbSubcategoria Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbSubcategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@cate_Id", item.cate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@subc_Descripcion", item.subc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_FechaCreacion", item.subc_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarSubCategoria, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public IEnumerable<tbSubcategoria> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbSubcategoria>(ScriptsDataBase.ListarSubCategoria, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbSubcategoria> ListByIdCategoria(int cate_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@cate_Id", cate_Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbSubcategoria>(ScriptsDataBase.ListarSubcategoriaByIdCategoria, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbSubcategoria item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@subc_Id", item.subc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@cate_Id", item.cate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@subc_Descripcion", item.subc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@subc_FechaModificacion", item.subc_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarSubCategoria, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

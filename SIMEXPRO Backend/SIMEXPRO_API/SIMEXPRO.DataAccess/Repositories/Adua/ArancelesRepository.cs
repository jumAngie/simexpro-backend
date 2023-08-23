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
    public class ArancelesRepository : IRepository<tbAranceles>
    {
        public RequestStatus Delete(tbAranceles item)
        {
            throw new NotImplementedException();
        }

        public tbAranceles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbAranceles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@aran_Codigo", item.aran_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@aran_Descripcion", item.aran_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_FechaCreacion", item.aran_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarAranceles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbAranceles> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbAranceles>(ScriptsDataBase.ListarAranceles, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbAranceles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@aran_Id", item.aran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_Codigo", item.aran_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@aran_Descripcion", item.aran_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_FechaModificacion", item.aran_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarAranceles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

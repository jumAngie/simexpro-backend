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
    public class RegimenesAduanerosRepository : IRepository<tbRegimenesAduaneros>
    {
        public RequestStatus Delete(tbRegimenesAduaneros item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@regi_Id",                  item.regi_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@regi_FechaEliminacion",    item.regi_FechaEliminacion,     DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarRegimenesAduaneros, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbRegimenesAduaneros Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbRegimenesAduaneros item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@regi_Codigo",           item.regi_Codigo,          DbType.String,   ParameterDirection.Input);
            parametros.Add("@regi_Descripcion",      item.regi_Descripcion,     DbType.String,   ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",  item.usua_UsuarioCreacion, DbType.Int32,    ParameterDirection.Input);
            parametros.Add("@regi_FechaCreacion",    item.regi_FechaCreacion,   DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarRegimenesAduaneros, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbRegimenesAduaneros> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbRegimenesAduaneros>(ScriptsDataBase.ListarRegimenesAduaneros, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbRegimenesAduaneros item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@regi_Id",                  item.regi_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@regi_Codigo",              item.regi_Codigo,               DbType.String,      ParameterDirection.Input);
            parametros.Add("@regi_Descripcion",         item.regi_Descripcion,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@regi_FechaModificacion",   item.regi_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarRegimenesAduaneros, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

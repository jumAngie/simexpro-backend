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
    public class AreasRepository : IRepository<tbArea>
    {
        public RequestStatus Delete(tbArea item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tipa_Id", item.tipa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tipa_FechaEliminacion", item.tipa_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarAreas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbArea Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbArea item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tipa_area",                item.tipa_area,             DbType.String,  ParameterDirection.Input);
            parametros.Add("@proc_Id",                  item.proc_Id,               DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",     item.usua_UsuarioCreacion,  DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@tipa_FechaCreacion",       item.tipa_FechaCreacion,    DbType.DateTime,ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarAreas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbArea> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbArea>(ScriptsDataBase.ListarAreas, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbArea item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tipa_Id",                  item.tipa_Id,                   DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@tipa_area",                item.tipa_area,                 DbType.String,  ParameterDirection.Input);
            parametros.Add("@proc_Id",                  item.proc_Id,                   DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@tipa_FechaModificacion",   item.tipa_FechaModificacion,    DbType.DateTime,ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarAreas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

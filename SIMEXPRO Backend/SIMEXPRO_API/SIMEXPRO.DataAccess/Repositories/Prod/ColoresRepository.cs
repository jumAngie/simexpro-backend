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
    public class ColoresRepository : IRepository<tbColores>
    {
        public IEnumerable<tbColores> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbColores>(ScriptsDataBase.ListarColores, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Delete(tbColores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colr_Id",                  item.colr_Id,                   DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colr_FechaEliminacion",    item.colr_FechaEliminacion,     DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarColores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbColores Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbColores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colr_Nombre",          item.colr_Nombre,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@colr_Codigo",          item.colr_Codigo,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@colr_CodigoHtml",      item.colr_CodigoHtml,       DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@colr_FechaCreacion",   item.colr_FechaCreacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarColores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public RequestStatus Update(tbColores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colr_Id",                      item.colr_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@colr_Nombre",                  item.colr_Nombre,               DbType.String,      ParameterDirection.Input);
            parametros.Add("@colr_Codigo",                  item.colr_Codigo,               DbType.String,      ParameterDirection.Input);
            parametros.Add("@colr_CodigoHtml",              item.colr_CodigoHtml,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion",     item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@colr_FechaModificacion",       item.colr_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarColores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


    }
}

using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Gral
{
    public class UnidadMedidasRepository : IRepository<tbUnidadMedidas>
    {
        public RequestStatus Delete(tbUnidadMedidas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@unme_Id",                  item.unme_Id,                   DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion,    DbType.Int32, ParameterDirection.Input);
            parametros.Add("@unme_FechaEliminacion",   item.unme_FechaEliminacion,      DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarUnidadMedidas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbUnidadMedidas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbUnidadMedidas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@unme_Descripcion",         item.unme_Descripcion,      DbType.String,  ParameterDirection.Input);
            parametros.Add("@unme_EsAduana",            item.unme_EsAduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",     item.usua_UsuarioCreacion,  DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@unme_FechaCreacion",       item.unme_FechaCreacion,    DbType.DateTime,ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarUnidadMedidas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbUnidadMedidas> List(bool? unme_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@unme_EsAduana", unme_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbUnidadMedidas>(ScriptsDataBase.ListarUnidadMedidas, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbUnidadMedidas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbUnidadMedidas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@unme_Id",                  item.unme_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@unme_Descripcion",         item.unme_Descripcion,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@unme_FechaModificacion",   item.unme_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarUnidadMedidas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

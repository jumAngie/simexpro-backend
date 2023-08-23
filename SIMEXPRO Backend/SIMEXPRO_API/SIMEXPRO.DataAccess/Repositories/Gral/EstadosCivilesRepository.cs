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
    public class EstadosCivilesRepository : IRepository<tbEstadosCiviles>
    {
        SIMEXPRO con = new SIMEXPRO();

        public RequestStatus Delete(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_FechaEliminacion", item.escv_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarEstadosCiviles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbEstadosCiviles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@escv_Nombre", item.escv_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_FechaCreacion", item.escv_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarEstadosCiviles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbEstadosCiviles> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var result = db.Query<tbEstadosCiviles>(ScriptsDataBase.ListarEstadosCiviles, null, commandType: CommandType.StoredProcedure);

            return result;
        }

        public RequestStatus Update(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_Nombre", item.escv_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_FechaModificacion", item.escv_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarEstadosCiviles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

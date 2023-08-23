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
    public class MaquinaHistorialRepository : IRepository<tbMaquinaHistorial>
    {
        public RequestStatus Delete(tbMaquinaHistorial item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mahi_Id", item.@mahi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mahi_FechaEliminacion", item.mahi_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMaquinasHistorial, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbMaquinaHistorial Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMaquinaHistorial item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@maqu_Id", item.maqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mahi_FechaInicio", item.mahi_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@mahi_FechaFin", item.mahi_FechaFin, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@mahi_Observaciones", item.mahi_Observaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mahi_FechaCreacion", item.mahi_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMaquinasHistorial, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMaquinaHistorial> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbMaquinaHistorial>(ScriptsDataBase.ListarMaquinasHistorial, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbMaquinaHistorial item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mahi_Id", item.mahi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@maqu_Id", item.maqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mahi_FechaInicio", item.mahi_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@mahi_FechaFin", item.mahi_FechaFin, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@mahi_Observaciones", item.mahi_Observaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mahi_FechaModificacion", item.mahi_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMaquinasHistorial, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

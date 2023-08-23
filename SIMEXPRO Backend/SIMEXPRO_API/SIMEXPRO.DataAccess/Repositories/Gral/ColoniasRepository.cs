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
    public class ColoniasRepository : IRepository<tbColonias>
    {
        public RequestStatus Delete(tbColonias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colo_Id", item.colo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_FechaEliminacion", item.colo_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarColonias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbColonias Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbColonias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colo_Nombre", item.colo_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@alde_Id", item.alde_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_FechaCreacion", item.colo_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarColonias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbColonias> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbColonias>(ScriptsDataBase.ListarColonias, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbColonias> ColoniasPorCiudades(int Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@ciud_Id", Id, DbType.String, ParameterDirection.Input);

            return db.Query<tbColonias>(ScriptsDataBase.ColoniasPorCiudades, parametros, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus Update(tbColonias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@colo_Id", item.colo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_Nombre", item.colo_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@alde_Id", item.alde_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_FechaModificacion", item.colo_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarColonias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

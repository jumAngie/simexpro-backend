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
    public class TipoEmbalajeRepository : IRepository<tbTipoEmbalaje>
    {


        public RequestStatus Delete(tbTipoEmbalaje item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@tiem_Id", item.tiem_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tiem_FechaEliminacion", item.tiem_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarTipoEmbalaje, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbTipoEmbalaje Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTipoEmbalaje item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@tiem_Descripcion", item.tiem_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tiem_FechaCreacion", item.tiem_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTipoEmbalaje, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public IEnumerable<tbTipoEmbalaje> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTipoEmbalaje>(ScriptsDataBase.ListarTipoEmbalaje, null, commandType: CommandType.StoredProcedure);
        }



        public RequestStatus Update(tbTipoEmbalaje item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@tiem_Id", item.tiem_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tiem_Descripcion", item.tiem_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tiem_FechaModificacion", item.tiem_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTipoEmbalaje, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

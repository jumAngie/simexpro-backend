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
    public class TiposIdentificacionRepository : IRepository<tbTiposIdentificacion>
    {
        public RequestStatus Delete(tbTiposIdentificacion item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@iden_Id", item.iden_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@iden_FechaEliminacion", item.iden_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarTiposIdentificacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbTiposIdentificacion Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTiposIdentificacion item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@iden_Descripcion", item.iden_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@iden_FechaCreacion", item.iden_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTiposIdentificacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTiposIdentificacion> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTiposIdentificacion>(ScriptsDataBase.ListarTiposIdentificacion, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbTiposIdentificacion item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@iden_Id", item.iden_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@iden_Descripcion", item.iden_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@iden_FechaModificacion", item.iden_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTiposIdentificacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
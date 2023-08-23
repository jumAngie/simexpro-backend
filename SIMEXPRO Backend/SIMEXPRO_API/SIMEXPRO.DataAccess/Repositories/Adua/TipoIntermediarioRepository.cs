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
    public class TipoIntermediarioRepository : IRepository<tbTipoIntermediario>
    {
        public RequestStatus Delete(tbTipoIntermediario item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tite_Id", item.tite_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tite_FechaEliminacion", item.tite_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarTipoIntermediario, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbTipoIntermediario Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTipoIntermediario item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tite_Codigo", item.tite_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tite_Descripcion", item.tite_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@tite_UsuCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tite_FechaCreacion", item.tite_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTipoIntermediario, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTipoIntermediario> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTipoIntermediario>(ScriptsDataBase.ListarTipoIntermediario, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbTipoIntermediario item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tite_Id", item.tite_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tite_Codigo", item.tite_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tite_Descripcion", item.tite_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@tite_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tite_FechaModicacion", item.tite_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTipoIntermediario, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

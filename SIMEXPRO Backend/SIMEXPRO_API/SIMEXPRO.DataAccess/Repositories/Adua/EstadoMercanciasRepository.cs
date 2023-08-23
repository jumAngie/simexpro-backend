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
    public class EstadoMercanciasRepository : IRepository<tbEstadoMercancias>
    {
        public RequestStatus Delete(tbEstadoMercancias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@merc_Id", item.merc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@merc_FechaEliminacion", item.merc_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarEstadoMercancias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbEstadoMercancias Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstadoMercancias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@merc_Codigo", item.merc_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@merc_Descripcion", item.merc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@merc_FechaCreacion", item.merc_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarEstadoMercancias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbEstadoMercancias> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbEstadoMercancias>(ScriptsDataBase.ListarEstadoMercancias, null, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus Update(tbEstadoMercancias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parametros = new DynamicParameters();

            parametros.Add("@merc_Id", item.merc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@merc_Codigo", item.merc_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@merc_Descripcion", item.merc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@merc_FechaModificacion", item.merc_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarEstadoMercancias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

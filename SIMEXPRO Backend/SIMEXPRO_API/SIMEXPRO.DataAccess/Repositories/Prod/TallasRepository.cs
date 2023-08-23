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
    public class TallasRepository : IRepository<tbTallas>
    {
        public RequestStatus Delete(tbTallas item)
        {
            throw new NotImplementedException();
        }

        public tbTallas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tall_Codigo", item.tall_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tall_Nombre", item.tall_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tall_FechaCreacion", item.tall_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTallas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public IEnumerable<tbTallas> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTallas>(ScriptsDataBase.ListarTallas, null, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus Update(tbTallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tall_Id", item.tall_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@tall_Codigo", item.tall_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tall_Nombre", item.tall_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tall_FechaModificacion", item.tall_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTallas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

    }
}

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
    public class CargosRepository : IRepository<tbCargos>
    {
        public RequestStatus Delete(tbCargos item)
        {
            throw new NotImplementedException();
        }

        public tbCargos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCargos item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_Nombre", item.carg_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@carg_Aduana", item.carg_Aduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_FechaCreacion", item.carg_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarCargos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbCargos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbCargos>(ScriptsDataBase.ListarCargos, null, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<tbCargos> List(bool? carg_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@carg_Aduana", carg_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbCargos>(ScriptsDataBase.ListarCargos, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbCargos item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Nombre", item.carg_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_FechaModificacion", item.carg_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarCargos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

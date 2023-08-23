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
    public class ModulosRepository : IRepository<tbModulos>
    {
        public RequestStatus Delete(tbModulos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_FechaEliminacion", item.modu_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarModulos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbModulos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbModulos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@modu_Nombre", item.modu_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@proc_Id", item.proc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empr_Id", item.empr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_FechaCreacion", item.modu_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarModulos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus= answer;
            return result;
        }

        public IEnumerable<tbModulos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbModulos>(ScriptsDataBase.ListarModulos, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbModulos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_Nombre", item.modu_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@proc_Id", item.proc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empr_Id", item.empr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_FechaModificacion", item.modu_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarModulos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

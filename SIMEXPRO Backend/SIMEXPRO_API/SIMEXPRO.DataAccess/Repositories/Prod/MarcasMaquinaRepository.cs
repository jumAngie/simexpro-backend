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
    public class MarcasMaquinaRepository : IRepository<tbMarcasMaquina>
    {
        public RequestStatus Delete(tbMarcasMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@marq_Id", item.marq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@marq_FechaEliminacion", item.marq_FechaEliminacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMarcasMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbMarcasMaquina Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMarcasMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@marq_Nombre", item.marq_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@marq_FechaCreacion", item.marq_FechaCreacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMarcasMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMarcasMaquina> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbMarcasMaquina>(ScriptsDataBase.ListarMarcasMaquina, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbMarcasMaquina item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@marq_Id", item.marq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@marq_Nombre", item.marq_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@marq_FechaModificacion", item.marq_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMarcasMaquina, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

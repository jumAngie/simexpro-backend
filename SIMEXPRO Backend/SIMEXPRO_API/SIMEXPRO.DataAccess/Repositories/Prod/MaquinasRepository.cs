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
    public class MaquinasRepository : IRepository<tbMaquinas>
    {
        public RequestStatus Delete(tbMaquinas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@maqu_Id", item.maqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@maqu_FechaEliminacion", item.maqu_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMaquinas, parametros, commandType: CommandType.StoredProcedure);
            result. MessageStatus = answer;
            return result;
        }

        public tbMaquinas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMaquinas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@maqu_NumeroSerie", item.maqu_NumeroSerie, DbType.String, ParameterDirection.Input);
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_Id", item.mmaq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@maqu_FechaCreacion", item.maqu_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMaquinas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMaquinas> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbMaquinas>(ScriptsDataBase.ListarMaquinas, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbMaquinas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@maqu_Id", item.maqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@maqu_NumeroSerie", item.maqu_NumeroSerie, DbType.String, ParameterDirection.Input);
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mmaq_Id", item.mmaq_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@maqu_FechaModificacion", item.maqu_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMaquinas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

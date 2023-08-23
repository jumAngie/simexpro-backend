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
    public class PersonasRepository : IRepository<tbPersonas>
    {
        public RequestStatus Delete(tbPersonas item)
        {
            throw new NotImplementedException();
        }

        public tbPersonas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPersonas item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pers_RTN", item.pers_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@ofic_Id", item.ofic_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_Id", item.ofpr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FormaRepresentacion", item.pers_FormaRepresentacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@pers_escvRepresentante", item.pers_escvRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_OfprRepresentante", item.pers_OfprRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FechaCreacion", item.pers_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPersonas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPersonas> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbPersonas>(ScriptsDataBase.ListarPersonas, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbPersonas item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pers_Id", item.pers_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_RTN", item.pers_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@ofic_Id", item.ofic_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_Id", item.ofpr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FormaRepresentacion", item.pers_FormaRepresentacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@pers_escvRepresentante", item.pers_escvRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_OfprRepresentante", item.pers_OfprRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FechaModificacion", item.pers_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPersonas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

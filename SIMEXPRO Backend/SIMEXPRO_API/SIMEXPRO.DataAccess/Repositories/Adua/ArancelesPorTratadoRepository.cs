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
    public class ArancelesPorTratadoRepository : IRepository<tbArancelesPorTratados>
    {
        public RequestStatus Delete(tbArancelesPorTratados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@axtl_Id", item.axtl_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarArancelPorTratado, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbArancelesPorTratados Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbArancelesPorTratados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@aran_Id", item.aran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@trli_Id", item.trli_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@axtl_TasaActual", item.axtl_TasaActual, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_usuarioCreacion", item.usua_usuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@axtl_FechaCreacion", item.axtl_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarArancelPorTratado, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;

        }

        public IEnumerable<tbArancelesPorTratados> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbArancelesPorTratados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@axtl_Id", item.axtl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@aran_Id", item.aran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@trli_Id", item.trli_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@axtl_TasaActual", item.axtl_TasaActual, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_usuarioCreacion", item.usua_usuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@axtl_FechaCreacion", item.axtl_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarArancelPorTratado, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class TratadosLibreComercioRepository : IRepository<tbTratadosLibreComercio>
    {
        public RequestStatus Delete(tbTratadosLibreComercio item)
        {
            throw new NotImplementedException();
        }

        public tbTratadosLibreComercio Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTratadosLibreComercio item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@trli_NombreTratado", item.trli_NombreTratado, DbType.String, ParameterDirection.Input);
            parametros.Add("@trli_FechaInicio", item.trli_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@detalles", item.detalles, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@trli_FechaCreacion", item.trli_FechaInicio, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTLC, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTratadosLibreComercio> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTratadosLibreComercio>(ScriptsDataBase.ListarTLC, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbTratadosLibreComercio item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@trli_Id", item.trli_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@trli_NombreTratado", item.trli_NombreTratado, DbType.String, ParameterDirection.Input);
            parametros.Add("@trli_FechaInicio", item.trli_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@detalles", item.detalles, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@trli_FechaModificacion", item.trli_FechaModificacion, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTLC, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTratadosLibreComercio> ListTratadosById(int trli_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@trli_Id", trli_Id, DbType.Int32, ParameterDirection.Input);

            return db.Query<tbTratadosLibreComercio>(ScriptsDataBase.ListTratadosById, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}

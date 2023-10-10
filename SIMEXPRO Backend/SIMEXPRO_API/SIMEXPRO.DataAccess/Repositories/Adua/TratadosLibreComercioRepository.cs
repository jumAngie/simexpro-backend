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
            throw new NotImplementedException();
        }

        public IEnumerable<tbTratadosLibreComercio> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbTratadosLibreComercio item)
        {
            throw new NotImplementedException();
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

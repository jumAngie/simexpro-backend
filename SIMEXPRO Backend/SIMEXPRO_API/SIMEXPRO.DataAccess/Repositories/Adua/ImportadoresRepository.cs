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
    public class ImportadoresRepository : IRepository<tbImportadores>
    {
        public RequestStatus Delete(tbImportadores item)
        {
            throw new NotImplementedException();
        }

        public tbImportadores Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbImportadores item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbImportadores> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbImportadores>(ScriptsDataBase.ListarImportadores, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbImportadores> ListarImportadoresById(int Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@impo_Id", Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbImportadores>(ScriptsDataBase.ListarImportadoresById, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbImportadores item)
        {
            throw new NotImplementedException();
        }
    }
}

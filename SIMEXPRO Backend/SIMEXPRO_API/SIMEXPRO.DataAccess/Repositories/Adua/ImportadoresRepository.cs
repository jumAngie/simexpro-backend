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

        public RequestStatus Update(tbImportadores item)
        {
            throw new NotImplementedException();
        }
    }
}

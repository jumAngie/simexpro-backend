using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Acce
{
    public class PantallasRepository : IRepository<tbPantallas>
    {
        public RequestStatus Delete(tbPantallas item)
        {
            throw new NotImplementedException();
        }

        public tbPantallas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPantallas item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPantallas> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbPantallas>(ScriptsDataBase.ListarPantallas, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbPantallas> List(bool? pant_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@pant_EsAduana", pant_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbPantallas>(ScriptsDataBase.ListarPantallas, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbPantallas item)
        {
            throw new NotImplementedException();
        }
    }
}

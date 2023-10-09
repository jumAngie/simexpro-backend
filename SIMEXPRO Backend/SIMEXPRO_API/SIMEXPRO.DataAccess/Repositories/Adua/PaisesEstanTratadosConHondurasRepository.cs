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
    public class PaisesEstanTratadosConHondurasRepository : IRepository<tbPaisesEstanTratadosConHonduras>
    {
        public RequestStatus Delete(tbPaisesEstanTratadosConHonduras item)
        {
            throw new NotImplementedException();
        }

        public tbPaisesEstanTratadosConHonduras Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPaisesEstanTratadosConHonduras item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPaisesEstanTratadosConHonduras> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbPaisesEstanTratadosConHonduras item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus TratadoByPaisId(int pais_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@pais_Id", pais_Id, DbType.Int32, ParameterDirection.Input);
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.TratadoByPaisId, parametros, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                CodeStatus = 1,
                MessageStatus = respuesta
            };
        }
    }
}

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
    public class LiquidacionGeneralRepository : IRepository<tbLiquidacionGeneral>
    {
        public RequestStatus Delete(tbLiquidacionGeneral item)
        {
            throw new NotImplementedException();
        }

        public tbLiquidacionGeneral Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbLiquidacionGeneral item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@lige_TipoTributo", item.lige_TipoTributo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_TotalPorTributo", item.lige_TotalPorTributo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_ModalidadPago", item.lige_ModalidadPago, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_TotalGral", item.lige_TotalGral, DbType.String, ParameterDirection.Input);
            parametros.Add("@duca_Id", item.duca_Id, DbType.String, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarLiquidacionGeneral, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbLiquidacionGeneral> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbLiquidacionGeneral>(ScriptsDataBase.ListarLiquidacionGeneral, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbLiquidacionGeneral item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@lige_Id", item.lige_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@lige_TipoTributo", item.lige_TipoTributo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_TotalPorTributo", item.lige_TotalPorTributo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_ModalidadPago", item.lige_ModalidadPago, DbType.String, ParameterDirection.Input);
            parametros.Add("@lige_TotalGral", item.lige_TotalGral, DbType.String, ParameterDirection.Input);
            parametros.Add("@duca_Id", item.duca_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@hlig_UsuarioAccion", 1, DbType.Int32, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarLiquidacionGeneral, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
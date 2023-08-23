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
    public class LiquidacionPorLineaRepository : IRepository<tbLiquidacionPorLinea>
    {
        public RequestStatus Delete(tbLiquidacionPorLinea item)
        {
            throw new NotImplementedException();
        }

        public tbLiquidacionPorLinea Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbLiquidacionPorLinea item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@lili_Tipo", item.lili_Tipo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lili_Alicuota", item.lili_Alicuota, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@lili_Total", item.lili_Total, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@lili_ModalidadPago", item.lili_ModalidadPago, DbType.String, ParameterDirection.Input);
            parametros.Add("@lili_TotalGral", item.lili_TotalGral, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarLiquidacionPorLinea, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbLiquidacionPorLinea> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbLiquidacionPorLinea>(ScriptsDataBase.ListarLiquidacionPorLinea, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbLiquidacionPorLinea item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@lili_Tipo", item.lili_Tipo, DbType.String, ParameterDirection.Input);
            parametros.Add("@lili_Alicuota", item.lili_Alicuota, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@lili_Total", item.lili_Total, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@lili_ModalidadPago", item.lili_ModalidadPago, DbType.String, ParameterDirection.Input);
            parametros.Add("@lili_TotalGral", item.lili_TotalGral, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarLiquidacionPorLinea, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
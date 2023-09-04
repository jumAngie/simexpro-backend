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
    public class BoletinPagoRepository : IRepository<tbBoletinPago>
    {
        public RequestStatus Delete(tbBoletinPago item)
        {
            throw new NotImplementedException();
        }

        public tbBoletinPago Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbBoletinPago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            
            var parametros = new DynamicParameters();
            parametros.Add("@liqu_Id", item.liqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parametros.Add("@tipl_Id", item.tipl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_FechaEmision", item.boen_FechaEmision, DbType.Date, ParameterDirection.Input);
            parametros.Add("@esbo_Id", item.esbo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_Observaciones", item.boen_Observaciones, DbType.String, ParameterDirection.Input);
            //parametros.Add("@boen_NDeclaracion", item.boen_NDeclaracion, DbType.String, ParameterDirection.Input);
            //parametros.Add("@pena_RTN", item.pena_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@boen_Preimpreso", item.boen_Preimpreso, DbType.String, ParameterDirection.Input);
            //parametros.Add("@boen_Declarante", item.boen_Declarante, DbType.String, ParameterDirection.Input);
            parametros.Add("@boen_TotalPagar", item.boen_TotalPagar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@boen_TotalGarantizar", item.boen_TotalGarantizar, DbType.Decimal, ParameterDirection.Input);
            //parametros.Add("@boen_RTN", item.boen_RTN, DbType.String, ParameterDirection.Input);
            //parametros.Add("@boen_TipoEncabezado", item.boen_TipoEncabezado, DbType.String, ParameterDirection.Input);
            parametros.Add("@coim_Id", item.coim_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@copa_Id", item.copa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_FechaCreacion", item.boen_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarBoletinPago, parametros, commandType: CommandType.StoredProcedure);
           
            return new RequestStatus()
            {
                MessageStatus = answer
            };
        }

        public IEnumerable<tbBoletinPago> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbBoletinPago>(ScriptsDataBase.ListarBoletinPago, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbBoletinPago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@boen_Id", item.boen_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@liqu_Id", item.liqu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parametros.Add("@tipl_Id", item.tipl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_FechaEmision", item.boen_FechaEmision, DbType.Date, ParameterDirection.Input);
            parametros.Add("@esbo_Id", item.esbo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_Observaciones", item.boen_Observaciones, DbType.String, ParameterDirection.Input);
            parametros.Add("@boen_NDeclaracion", item.boen_NDeclaracion, DbType.String, ParameterDirection.Input);
            //parametros.Add("@pena_RTN", item.pena_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@boen_Preimpreso", item.boen_Preimpreso, DbType.String, ParameterDirection.Input);
            //parametros.Add("@boen_Declarante", item.boen_Declarante, DbType.String, ParameterDirection.Input);
            parametros.Add("@boen_TotalPagar", item.boen_TotalPagar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@boen_TotalGarantizar", item.boen_TotalGarantizar, DbType.Decimal, ParameterDirection.Input);
            //parametros.Add("@boen_RTN", item.boen_RTN, DbType.String, ParameterDirection.Input);
            //parametros.Add("@boen_TipoEncabezado", item.boen_TipoEncabezado, DbType.String, ParameterDirection.Input);
            parametros.Add("@coim_Id", item.coim_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@copa_Id", item.copa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_FechaModificacion", item.boen_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarBoletinPago, parametros, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = answer
            };
        }
    }
}

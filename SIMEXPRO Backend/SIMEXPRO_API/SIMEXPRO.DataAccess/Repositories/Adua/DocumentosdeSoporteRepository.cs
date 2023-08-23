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
    public class DocumentosdeSoporteRepository : IRepository<tbDocumentosDeSoporte>
    {
        public RequestStatus Delete(tbDocumentosDeSoporte item)
        {
            throw new NotImplementedException();
        }

        public tbDocumentosDeSoporte Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDocumentosDeSoporte item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@tido_Id", item.tido_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parametros.Add("@doso_NumeroDocumento", item.doso_NumeroDocumento, DbType.String, ParameterDirection.Input);
            parametros.Add("@doso_FechaEmision", item.doso_FechaEmision, DbType.Date, ParameterDirection.Input);
            parametros.Add("@doso_FechaVencimiento", item.doso_FechaVencimiento, DbType.Date, ParameterDirection.Input);
            parametros.Add("@doso_PaisEmision", item.doso_PaisEmision, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doso_LineaAplica", item.doso_LineaAplica, DbType.String, ParameterDirection.Input);
            parametros.Add("@doso_EntidadEmitioDocumento", item.doso_EntidadEmitioDocumento, DbType.String, ParameterDirection.Input);
            parametros.Add("@doso_Monto", item.doso_Monto, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doso_FechaCreacion", item.doso_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentosSoporte, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbDocumentosDeSoporte> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDocumentosDeSoporte>(ScriptsDataBase.ListarDocumentosSoporte, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbDocumentosDeSoporte item)
        {
            throw new NotImplementedException();
        }
    }
}

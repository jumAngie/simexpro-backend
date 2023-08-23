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
    public class DocumentosPDFRepository : IRepository<tbDocumentosPDF>
    {
        public RequestStatus Delete(tbDocumentosPDF item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@dpdf_Id", item.dpdf_Id, DbType.Int32, ParameterDirection.Input);
         
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosPDF, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbDocumentosPDF Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDocumentosPDF item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dpdf_CA", item.dpdf_CA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_DVA", item.dpdf_DVA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_DUCA", item.dpdf_DUCA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_Boletin", item.dpdf_Boletin, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dpdf_FechaCreacion", item.dpdf_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentosPDF, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbDocumentosPDF> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDocumentosPDF>(ScriptsDataBase.ListarDocumentosPDF, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbDocumentosPDF item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@dpdf_Id", item.dpdf_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dpdf_CA", item.dpdf_CA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_DVA", item.dpdf_DVA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_DUCA", item.dpdf_DUCA, DbType.String, ParameterDirection.Input);
            parametros.Add("@dpdf_Boletin", item.dpdf_Boletin, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dpdf_FechaModificacion", item.dpdf_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarDocumentosPDF, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class DocumentosContratosRepository : IRepository<tbDocumentosContratos>
    {
        public RequestStatus Delete(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@doco_Id", item.doco_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosContratos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbDocumentosContratos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peju_Id", item.peju_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_Numero_O_Referencia", item.doco_Numero_O_Referencia, DbType.String, ParameterDirection.Input);
            parametros.Add("@doco_TipoDocumento", item.doco_TipoDocumento, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_FechaCreacion", item.doco_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentosContratos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbDocumentosContratos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDocumentosContratos>(ScriptsDataBase.ListarDocumentosContratos, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@doco_Id", item.doco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peju_Id", item.peju_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_Numero_O_Referencia", item.doco_Numero_O_Referencia, DbType.String, ParameterDirection.Input);
            parametros.Add("@doco_TipoDocumento", item.doco_TipoDocumento, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_FechaCreacion", item.doco_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarDocumentosContratos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

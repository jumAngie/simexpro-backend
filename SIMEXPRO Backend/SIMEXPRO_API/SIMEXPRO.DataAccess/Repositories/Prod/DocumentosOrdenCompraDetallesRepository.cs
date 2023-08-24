using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Prod
{
    public class DocumentosOrdenCompraDetallesRepository : IRepository<tbDocumentosOrdenCompraDetalles>
    {
        public RequestStatus Delete(tbDocumentosOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@dopo_Id", item.dopo_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbDocumentosOrdenCompraDetalles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDocumentosOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dopo_NombreArchivo", item.dopo_Archivo, DbType.String, ParameterDirection.Input);
            parametros.Add("@dopo_Archivo", item.dopo_Archivo, DbType.String, ParameterDirection.Input);
            parametros.Add("@dopo_TipoArchivo", item.dopo_TipoArchivo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dopo_FechaCreacion", item.dopo_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentosOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbDocumentosOrdenCompraDetalles> ListarByCodeId(int code_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", code_Id, DbType.Int32, ParameterDirection.Input);
            var result = db.Query<tbDocumentosOrdenCompraDetalles>(ScriptsDataBase.ListarDocumentosOrdenCompraDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<tbDocumentosOrdenCompraDetalles> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbDocumentosOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@dopo_Id", item.dopo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dopo_Archivo", item.dopo_Archivo, DbType.String, ParameterDirection.Input);
            parametros.Add("@dopo_TipoArchivo", item.dopo_TipoArchivo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dopo_FechaModificacion", item.dopo_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarDocumentosOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

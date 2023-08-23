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
    public class TipoDocumentoRepository : IRepository<tbTipoDocumento>
    {
        public RequestStatus Delete(tbTipoDocumento item)
        {
            throw new NotImplementedException();
        }

        public tbTipoDocumento Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTipoDocumento item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tido_Codigo", item.tido_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tido_Descripcion", item.tido_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tido_FechaCrea", item.tido_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTipoDocumento, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTipoDocumento> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbTipoDocumento>(ScriptsDataBase.ListarTipoDocumento, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbTipoDocumento item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tido_Id", item.tido_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tido_Codigo", item.tido_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@tido_Descripcion", item.tido_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tido_FechaModificacion", item.tido_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTipoDocumento, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class DocumentosSancionesRepository : IRepository<tbDocumentosSanciones>
    {
        public RequestStatus Delete(tbDocumentosSanciones item)
        {
            throw new NotImplementedException();
        }

        public tbDocumentosSanciones Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDocumentosSanciones item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();
            parameters.Add("@dosa_NombreDocumento", item.dosa_NombreDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@dosa_UrlDocumento", item.dosa_UrlDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@dosa_FechaCreacion", item.dosa_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentodeSanciones, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {   
                CodeStatus = respuesta != "1" ? 0 : int.Parse(respuesta),
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbDocumentosSanciones> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbDocumentosSanciones>(ScriptsDataBase.ListarDocumentosdeSanciones, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbDocumentosSanciones item)
        {
            throw new NotImplementedException();
        }
    }
}

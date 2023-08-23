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
    public class ConceptoPagoRepository : IRepository<tbConceptoPago>
    {
        public RequestStatus Delete(tbConceptoPago item)
        {
            throw new NotImplementedException();
        }

        public tbConceptoPago Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbConceptoPago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            var resultado = new RequestStatus();

            parametros.Add("@copa_Descripcion", item.copa_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@copa_FechaCreacion", item.copa_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarConceptoPago, parametros, commandType: CommandType.StoredProcedure);

            resultado.MessageStatus = respuesta;

            return resultado;
        }

        public IEnumerable<tbConceptoPago> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var resultado = db.Query<tbConceptoPago>(ScriptsDataBase.ListarConceptoPago, null, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public RequestStatus Update(tbConceptoPago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            var resultado = new RequestStatus();

            parametros.Add("@copa_Id", item.copa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@copa_Descripcion", item.copa_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@copa_FechaModificacion", item.copa_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarConceptoPago, parametros, commandType: CommandType.StoredProcedure);

            resultado.MessageStatus = respuesta;

            return resultado;
        }
    }
}
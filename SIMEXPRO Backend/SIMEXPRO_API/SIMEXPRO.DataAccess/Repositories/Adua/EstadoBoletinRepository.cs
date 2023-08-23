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
    public class EstadoBoletinRepository : IRepository<tbEstadoBoletin>
    {
        public RequestStatus Delete(tbEstadoBoletin item)
        {
            throw new NotImplementedException();
        }

        public tbEstadoBoletin Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstadoBoletin item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            
            var parameters = new DynamicParameters();
            parameters.Add("@esbo_Descripcion", item.esbo_Descripcion, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@esbo_FechaCreacion", item.esbo_FechaCreacion, DbType.String, ParameterDirection.Input);
            
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarEstadoBoletin, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbEstadoBoletin> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbEstadoBoletin>(ScriptsDataBase.ListarEstadoBoletin, null, commandType: System.Data.CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbEstadoBoletin item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();
            parameters.Add("@esbo_Id", item.esbo_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@esbo_Descripcion", item.esbo_Descripcion, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@esbo_FechaModificacion", item.esbo_FechaModificacion, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarEstadoBoletin, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }
    }
}

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
    public class FormasdePagoRepository : IRepository<tbFormasdePago>
    {
        public RequestStatus Delete(tbFormasdePago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@fopa_id", item.fopa_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@fopa_FechaEliminacion", item.fopa_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EliminarFormasdePago, parameters, commandType: CommandType.StoredProcedure);
            
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public tbFormasdePago Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFormasdePago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();
            parameters.Add("@fopa_Descripcion", item.fopa_Descripcion, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@fopa_FechaCreacion", item.fopa_FechaCreacion, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarFormasdePago, parameters, commandType: CommandType.StoredProcedure);
            
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbFormasdePago> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbFormasdePago>(ScriptsDataBase.ListarFormasdePago, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbFormasdePago item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            
            var parameters = new DynamicParameters();
            parameters.Add("@fopa_id", item.fopa_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@fopa_Descripcion", item.fopa_Descripcion, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@fopa_FechaModificacion", item.fopa_FechaModificacion, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarFormasdePago, parameters, commandType: CommandType.StoredProcedure);
           
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }
    }
}

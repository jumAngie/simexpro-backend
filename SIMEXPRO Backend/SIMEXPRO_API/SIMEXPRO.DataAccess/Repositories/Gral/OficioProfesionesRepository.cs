using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Gral
{
    public class OficioProfesionesRepository : IRepository<tbOficio_Profesiones>
    {
        public RequestStatus Delete(tbOficio_Profesiones item)
        {
            throw new NotImplementedException();
        }

        public tbOficio_Profesiones Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbOficio_Profesiones item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ofpr_Nombre", item.ofpr_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_FechaCreacion", item.ofpr_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarOficioProfesion, parametros, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbOficio_Profesiones> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbOficio_Profesiones>(ScriptsDataBase.ListarOficioProfesion, null, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus Update(tbOficio_Profesiones item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ofpr_Id", item.ofpr_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@ofpr_Nombre", item.ofpr_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_FechaModificacion", item.ofpr_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarOficioProfesion, parametros, commandType: CommandType.StoredProcedure);
           
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }
    }
}

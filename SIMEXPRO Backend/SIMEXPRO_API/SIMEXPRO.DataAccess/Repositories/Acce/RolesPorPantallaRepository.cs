using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Acce
{
    public class RolesPorPantallaRepository : IRepository<tbRolesXPantallas>
    {
        public RequestStatus Delete(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarRolesXPantallas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbRolesXPantallas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pant_Id", item.pant_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ropa_FechaCreacion", item.ropa_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarRolesXPantallas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbRolesXPantallas> Lista(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbRolesXPantallas>(ScriptsDataBase.ListarRolesXPantallas, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<tbRolesXPantallas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pant_Id", item.pant_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_Id", item.role_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarRolesXPantallas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
        public IEnumerable<tbRolesXPantallas> DibujarMenu(int role_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@role_Id", role_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.Query<tbRolesXPantallas>(ScriptsDataBase.DibujarMenuRolesXPantallas, parametros, commandType: CommandType.StoredProcedure);
            return answer;
        }
        public IEnumerable<tbPantallas> DibujadoDeMenu()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var answer = db.Query<tbPantallas>(ScriptsDataBase.DibujadoMenu, null, commandType: CommandType.StoredProcedure);
            return answer;
        }
    }
}

using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.DataAccess.Context;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Gral
{
    public class CiudadesRepository : IRepository<tbCiudades>
    {
        public RequestStatus Delete(tbCiudades item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_FechaEliminacion", item.ciud_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarCiudades, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;       
        }

        public tbCiudades Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCiudades item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ciud_Nombre", item.ciud_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@pvin_Id", item.pvin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_EsAduana", item.ciud_EsAduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_FechaCreacion", item.ciud_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarCiudades, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbCiudades> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<tbCiudades>(ScriptsDataBase.ListarCiudades, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbCiudades> List(bool? ciud_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@ciud_EsAduana", ciud_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbCiudades>(ScriptsDataBase.ListarCiudades, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbCiudades> CiudadesPorProvincia(int Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@pvin_Id", Id, DbType.String, ParameterDirection.Input);

            return db.Query<tbCiudades>(ScriptsDataBase.CiudadesPorProvincia, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCiudades item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@ciud_Nombre", item.ciud_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@pvin_Id", item.pvin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_FechaModificacion", item.ciud_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarCiudades, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class ProvinciasRepository : IRepository<tbProvincias>
    {
     

        public RequestStatus Delete(tbProvincias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pvin_Id", item.pvin_Id, DbType.Int32, ParameterDirection.Input);          
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pvin_FechaEliminacion", item.pvin_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarProvincias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbProvincias Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbProvincias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pvin_Nombre",          item.pvin_Nombre,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@pvin_Codigo",          item.pvin_Codigo,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@pais_Id",              item.pais_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@pvin_EsAduana",        item.pvin_EsAduana,         DbType.Boolean,     ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@pvin_FechaCreacion",   item.pvin_FechaCreacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarProvincias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbProvincias> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbProvincias>(ScriptsDataBase.ListarProvincias, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbProvincias> List(bool? pvin_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pvin_EsAduana", pvin_EsAduana, DbType.Boolean, ParameterDirection.Input);
            return db.Query<tbProvincias>(ScriptsDataBase.ListarProvincias, parametros, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<tbProvincias> ProvinciasPorPaises(int pais_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pais_Id", pais_Id, DbType.String, ParameterDirection.Input);
            return db.Query<tbProvincias>(ScriptsDataBase.ProvinciasPorPais, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbProvincias item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pvin_Id",                  item.pvin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pvin_Nombre",              item.pvin_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@pvin_Codigo",              item.pvin_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pais_Id",                  item.pais_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pvin_FechaModificacion",   item.pvin_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarProvincias, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

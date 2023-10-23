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
    public class AduanasRepository : IRepository<tbAduanas>
    {
        public RequestStatus Delete(tbAduanas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@adua_Id", item.adua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_FechaEliminacion", item.adua_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarAduanas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;

            return result;
        }

        public tbAduanas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbAduanas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@adua_Nombre", item.adua_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@adua_Codigo", item.adua_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_Direccion_Exacta", item.adua_Direccion_Exacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_FechaCreacion", item.adua_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarAduanas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbAduanas> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbAduanas>(ScriptsDataBase.ListarAduanas, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbAduanas> List_ById(int id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@adua_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbAduanas>(ScriptsDataBase.ListarAduanasById, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbAduanas> List_ByCode(string code)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@adua_Codigo", code, DbType.String, ParameterDirection.Input);
            return db.Query<tbAduanas>(ScriptsDataBase.ListarAduasByCode, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbAduanas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@adua_Id", item.adua_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_Nombre", item.adua_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@adua_Codigo", item.adua_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_Direccion_Exacta", item.adua_Direccion_Exacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@adua_FechaModificacion", item.adua_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarAduanas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

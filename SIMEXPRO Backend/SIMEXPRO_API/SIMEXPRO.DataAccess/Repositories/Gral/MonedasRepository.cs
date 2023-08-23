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
    public class MonedasRepository : IRepository<tbMonedas>
    {
        public RequestStatus Delete(tbMonedas item)
        {
            //using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            //RequestStatus result = new RequestStatus();
            //var parametros = new DynamicParameters();
            //parametros.Add("@mone_Id", item.mone_Id, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@mone_FechaEliminacion", item.mone_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);
            //var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMonedas, parametros, commandType: CommandType.StoredProcedure);
            //result.MessageStatus = answer;
            //return result;

            throw new NotImplementedException();
        }

        public tbMonedas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMonedas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mone_Codigo", item.mone_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@mone_Descripcion", item.mone_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@mone_EsAduana", item.mone_EsAduana, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mone_FechaCreacion", item.mone_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMonedas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMonedas> List(bool? mone_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@mone_EsAduana", mone_EsAduana, DbType.Boolean, ParameterDirection.Input);

            return db.Query<tbMonedas>(ScriptsDataBase.ListarMonedas, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbMonedas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbMonedas item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mone_Id", item.mone_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mone_Codigo", item.mone_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@mone_Descripcion", item.mone_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mone_FechaModificacion", item.mone_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMonedas, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class LugaresEmbarqueRepository : IRepository<tbLugaresEmbarque>
    {
        public RequestStatus Delete(tbLugaresEmbarque item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@emba_Id", item.emba_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@emba_FechaEliminacion", item.emba_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarLugaresEmbarque, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbLugaresEmbarque Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbLugaresEmbarque item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@emba_Codigo", item.emba_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@emba_Descripcion", item.emba_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@emba_FechaCreacion", item.emba_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarLugaresEmbarque, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbLugaresEmbarque> List(string codigo)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@emba_Codigo", codigo, DbType.String, ParameterDirection.Input);
            return db.Query<tbLugaresEmbarque>(ScriptsDataBase.ListarLugaresEmbarque, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbLugaresEmbarque> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbLugaresEmbarque item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@emba_Id", item.emba_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@emba_Codigo", item.emba_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@emba_Descripcion", item.emba_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@emba_FechaModificacion", item.emba_FechaModificacion, DbType.DateTime, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarLugaresEmbarque, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
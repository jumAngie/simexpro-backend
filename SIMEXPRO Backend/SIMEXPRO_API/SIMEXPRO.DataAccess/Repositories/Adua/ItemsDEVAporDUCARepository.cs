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
    public class ItemsDEVAporDUCARepository : IRepository<tbItemsDEVAPorDuca>
    {
        public RequestStatus Delete(tbItemsDEVAPorDuca item)
        {
            throw new NotImplementedException();
        }

        public tbItemsDEVAPorDuca Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbItemsDEVAPorDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@duca_No_DUCA", item.duca_No_DUCA, DbType.String, ParameterDirection.Input);
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dedu_FechaCreacion", item.dedu_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarItemDEVAxDuca, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbItemsDEVAPorDuca> List()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VW_tbDeclaraciones_ValorCompleto> ListDVxDC(int DucaNo)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@duca_Id", DucaNo, DbType.String, ParameterDirection.Input);
            return db.Query<VW_tbDeclaraciones_ValorCompleto>(ScriptsDataBase.LitarItemDEVAxDuca, parametros, commandType: CommandType.StoredProcedure);
 
        }

        public RequestStatus Update(tbItemsDEVAPorDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@dedu_Id",                  item.dedu_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@duca_No_DUCA",             item.duca_No_DUCA,              DbType.String,      ParameterDirection.Input);
            parametros.Add("@deva_Id",                  item.deva_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@dedu_FechaModificacion",   item.dedu_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarItemDevaxDuca, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

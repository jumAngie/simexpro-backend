using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Prod
{
    public class AsignacionesOrdenDetalleRepository : IRepository<tbAsignacionesOrdenDetalle>
    {
        public RequestStatus Delete(tbAsignacionesOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@adet_Id", item.adet_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarAsignacionesOrdenDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbAsignacionesOrdenDetalle Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbAsignacionesOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@lote_Id",                  item.lote_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@adet_Cantidad",            item.adet_Cantidad,         DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_Id",                  item.asor_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",     item.usua_UsuarioCreacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@adet_FechaCreacion",       item.adet_FechaCreacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarAsignacinesOrdenDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbAsignacionesOrdenDetalle> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            return db.Query<tbAsignacionesOrdenDetalle>(ScriptsDataBase.ListarAsignacionesOrdenDetalle, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbAsignacionesOrdenDetalle item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@adet_Id",                   item.adet_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@lote_Id",                   item.lote_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@adet_Cantidad",             item.adet_Cantidad,             DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_Id",                   item.asor_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion",  item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@adet_FechaModificacion",    item.adet_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarAsignacionesOrdenDetalle, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbAsignacionesOrdenDetalle> List(int asor_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@asor_Id", asor_Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbAsignacionesOrdenDetalle>(ScriptsDataBase.ListarAsignacionesOrdenDetalle, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}

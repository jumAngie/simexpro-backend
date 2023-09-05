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
    public class AsignacionesOrdenRepository : IRepository<tbAsignacionesOrden>
    {
        public RequestStatus Delete(tbAsignacionesOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@asor_Id", item.asor_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarAsignacionesOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        //Este find es para mostrar los campos "estilo", "talla" y "color" a la hora de escribir el id de la PO detalle en el modal de asignaciones

        public tbAsignacionesOrden Find(int? id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<tbAsignacionesOrden>(ScriptsDataBase.FindOrdenCompraDetalle, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Insert(tbAsignacionesOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@asor_OrdenDetId",      item.asor_OrdenDetId,       DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_FechaInicio",     item.asor_FechaInicio,      DbType.DateTime,    ParameterDirection.Input);
            parametros.Add("@asor_FechaLimite",     item.asor_FechaLimite,      DbType.DateTime,    ParameterDirection.Input);
            parametros.Add("@asor_Cantidad",        item.asor_Cantidad,         DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@proc_Id",              item.proc_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@empl_Id",              item.empl_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@detalles",             item.Detalles,              DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_FechaCreacion",   item.asor_FechaCreacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarAsignacinesOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbAsignacionesOrden> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbAsignacionesOrden>(ScriptsDataBase.ListarAsignacionesOrden, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbAsignacionesOrden item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@asor_Id",                  item.asor_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_OrdenDetId",          item.asor_OrdenDetId,           DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_FechaInicio",         item.asor_FechaInicio,          DbType.DateTime,    ParameterDirection.Input);
            parametros.Add("@asor_FechaLimite",         item.asor_FechaLimite,          DbType.DateTime,    ParameterDirection.Input);
            parametros.Add("@asor_Cantidad",            item.asor_Cantidad,             DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@proc_Id",                  item.proc_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@empl_Id",                  item.empl_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@asor_FechaModificacion",   item.asor_FechaCreacion,        DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarAsignacionesOrden, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

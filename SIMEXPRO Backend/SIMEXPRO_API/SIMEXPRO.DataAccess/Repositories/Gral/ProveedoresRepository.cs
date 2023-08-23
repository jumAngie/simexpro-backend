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
    public class ProveedoresRepository : IRepository<tbProveedores>
    {
        public RequestStatus Delete(tbProveedores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id",                  item.prov_Id,                   DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@prov_FechaEliminacion",    item.prov_FechaEliminacion,     DbType.DateTime,ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarProveedores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbProveedores Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbProveedores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prov_NombreCompania",   item.prov_NombreCompania,    DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_NombreContacto",   item.prov_NombreContacto,    DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_Telefono",         item.prov_Telefono,          DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_CodigoPostal",     item.prov_CodigoPostal,      DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_Ciudad",           item.prov_Ciudad,            DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@prov_DireccionExacta",  item.prov_DireccionExacta,   DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_CorreoElectronico",item.prov_CorreoElectronico, DbType.String,  ParameterDirection.Input);
            parametros.Add("@prov_Fax",              item.prov_Fax,               DbType.String,  ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion",  item.usua_UsuarioCreacion,   DbType.Int32,   ParameterDirection.Input);
            parametros.Add("@prov_FechaCreacion",    item.prov_FechaCreacion,     DbType.DateTime,ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertaProveedores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbProveedores> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbProveedores>(ScriptsDataBase.ListarProveedores, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbProveedores item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id",                  item.prov_Id,               DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@prov_NombreCompania",      item.prov_NombreCompania,   DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_NombreContacto",      item.prov_NombreContacto,   DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_Telefono",            item.prov_Telefono,         DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_CodigoPostal",        item.prov_CodigoPostal,     DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_Ciudad",              item.prov_Ciudad,           DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@prov_DireccionExacta",     item.prov_DireccionExacta,  DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_CorreoElectronico",   item.prov_CorreoElectronico,DbType.String,      ParameterDirection.Input);
            parametros.Add("@prov_Fax",                 item.prov_Fax,              DbType.String,      ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@prov_FechaModificacion",   item.prov_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarProveedores, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
        
    }
}

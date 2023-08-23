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
    public class CondicionesComercialesRepository : IRepository<tbCondicionesComerciales>
    {
        public RequestStatus Delete(tbCondicionesComerciales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coco_Id",                  item.coco_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion",  item.usua_UsuarioEliminacion,   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@coco_FechaEliminacion",    item.coco_FechaEliminacion,     DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarCondicionesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbCondicionesComerciales Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCondicionesComerciales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coco_Codigo",          item.coco_Codigo,           DbType.String,      ParameterDirection.Input);
            parametros.Add("@coco_Descripcion",     item.coco_Descripcion,      DbType.String,      ParameterDirection.Input);
            parametros.Add("@coco_UsuCreacion",     item.usua_UsuarioCreacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@coco_FechaCreacion",   item.coco_FechaCreacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarCondicionesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbCondicionesComerciales> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbCondicionesComerciales>(ScriptsDataBase.ListarCondicionesComerciales, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCondicionesComerciales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coco_Id",                      item.coco_Id,                   DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@coco_Codigo",                  item.coco_Codigo,               DbType.String,      ParameterDirection.Input);
            parametros.Add("@coco_Descripcion",             item.coco_Descripcion,          DbType.String,      ParameterDirection.Input);
            parametros.Add("@coco_UsuarioModificacion",     item.usua_UsuarioModificacion,  DbType.Int32,       ParameterDirection.Input);
            parametros.Add("@coco_FechaModi",               item.coco_FechaModificacion,    DbType.DateTime,    ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarCondicionesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

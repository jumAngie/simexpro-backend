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
    public class TipoLiquidacionRepository : IRepository<tbTipoLiquidacion>
    {
        public RequestStatus Delete(tbTipoLiquidacion item)
        {
            throw new NotImplementedException();
        }

        public tbTipoLiquidacion Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTipoLiquidacion item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tipl_Descripcion", item.tipl_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tipl_FechaCreacion", item.tipl_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTipoLiquidacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTipoLiquidacion> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTipoLiquidacion>(ScriptsDataBase.ListarTipoLiquidacion, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbTipoLiquidacion item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tipl_Id", item.tipl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tipl_Descripcion", item.tipl_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tipl_FechaModificacion", item.tipl_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTipoLiquidacion, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

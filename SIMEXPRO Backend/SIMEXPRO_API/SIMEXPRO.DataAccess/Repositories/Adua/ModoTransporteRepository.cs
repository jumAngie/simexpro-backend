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
    public class ModoTransporteRepository : IRepository<tbModoTransporte>
    {
        public RequestStatus Delete(tbModoTransporte item)
        {
            throw new NotImplementedException();
        }

        public tbModoTransporte Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbModoTransporte item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@motr_Descripcion", item.motr_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@motr_FechaCreacion", item.motr_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarModoTransporte, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbModoTransporte> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbModoTransporte>(ScriptsDataBase.ListarModoTransporte, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbModoTransporte item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@motr_Id", item.motr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@motr_Descripcion", item.motr_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@motr_FechaModificacion", item.motr_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarModoTransporte, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
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
    public class MaterialesRepository : IRepository<tbMateriales>
    {
        public RequestStatus Delete(tbMateriales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarMateriales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbMateriales Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMateriales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mate_Descripcion", item.mate_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@subc_Id", item.subc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colr_Id", item.colr_Id, DbType.Int32, ParameterDirection.Input);
            // parametros.Add("@mate_Precio", item.mate_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@mate_Imagen", item.mate_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_FechaCreacion", item.mate_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarMateriales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbMateriales> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbMateriales>(ScriptsDataBase.ListarMateriales, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbMateriales item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@mate_Id", item.mate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_Descripcion", item.mate_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@subc_Id", item.subc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colr_Id", item.colr_Id, DbType.Int32, ParameterDirection.Input);
            //  parametros.Add("@mate_Precio", item.mate_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@mate_Imagen", item.mate_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mate_FechaModificacion", item.mate_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarMateriales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

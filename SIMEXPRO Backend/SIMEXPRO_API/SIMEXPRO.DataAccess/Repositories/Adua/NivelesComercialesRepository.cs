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
    public class NivelesComercialesRepository : IRepository<tbNivelesComerciales>
    {
        public RequestStatus Delete(tbNivelesComerciales item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@nico_Id", item.nico_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nico_FechaEliminacion", item.nico_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarNivelesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbNivelesComerciales Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbNivelesComerciales item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@nico_Codigo", item.nico_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@nico_Descripcion", item.nico_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nico_FechaCreacion", item.nico_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarNivelesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbNivelesComerciales> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbNivelesComerciales>(ScriptsDataBase.ListarNivelesComerciales, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbNivelesComerciales item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@nico_Id", item.nico_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nico_Codigo", item.nico_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@nico_Descripcion", item.nico_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nico_FechaModificacion", item.nico_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarNivelesComerciales, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
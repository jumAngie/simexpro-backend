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
    public class RevisionDeCalidadRepository : IRepository<tbRevisionDeCalidad>
    {
        public RequestStatus Delete(tbRevisionDeCalidad item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@reca_Id", item.reca_Id, DbType.Int32, ParameterDirection.Input);
         
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarRevisionDeCalidad, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbRevisionDeCalidad Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbRevisionDeCalidad item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ensa_Id", item.ensa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_Descripcion", item.reca_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@reca_Cantidad", item.reca_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_Scrap", item.reca_Scrap, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@reca_FechaRevision", item.reca_FechaRevision, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@reca_Imagen", item.reca_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_FechaCreacion", item.reca_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertaRevisionDeCalidad, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbRevisionDeCalidad> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbRevisionDeCalidad>(ScriptsDataBase.ListarRevisionDeCalidad, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbOrde_Ensa_Acab_Etiq> NewList(int ensa_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@ensa_Id", ensa_Id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbOrde_Ensa_Acab_Etiq>(ScriptsDataBase.NuevoListarRevisionDeCalidad, parametros, commandType: CommandType.StoredProcedure);
        }




        public RequestStatus Update(tbRevisionDeCalidad item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@reca_Id", item.reca_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_Id", item.ensa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_Descripcion", item.reca_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@reca_Cantidad", item.reca_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_Scrap", item.reca_Scrap, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@reca_FechaRevision", item.reca_FechaRevision, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@reca_Imagen", item.reca_Imagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@reca_FechaModificacion", item.reca_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarRevisionDeCalidad, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

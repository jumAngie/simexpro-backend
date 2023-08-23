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
    public class TransporteRepository : IRepository<tbTransporte>
    {
        public RequestStatus Delete(tbTransporte item)
        {
            throw new NotImplementedException();
        }

        public tbTransporte Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTransporte item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@pais_Id", item.pais_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_Chasis", item.tran_Chasis, DbType.String, ParameterDirection.Input);
            parametros.Add("@marca_Id", item.marca_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_IdRemolque", item.tran_Remolque, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_CantCarga", item.tran_CantCarga, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_NumDispositivoSeguridad", item.tran_NumDispositivoSeguridad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_Equipamiento", item.tran_Equipamiento, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_TipoCarga", item.tran_TipoCarga, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_IdContenedor", item.tran_IdContenedor, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacio", item.usua_UsuarioCreacio, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_FechaCreacion", item.tran_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarTransporte, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbTransporte> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbTransporte>(ScriptsDataBase.ListarTransporte, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbTransporte item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@tran_Id", item.tran_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_Id", item.pais_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_Chasis", item.tran_Chasis, DbType.String, ParameterDirection.Input);
            parametros.Add("@marca_Id", item.marca_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_IdRemolque", item.tran_Remolque, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_CantCarga", item.tran_CantCarga, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_NumDispositivoSeguridad", item.tran_NumDispositivoSeguridad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_Equipamiento", item.tran_Equipamiento, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_TipoCarga", item.tran_TipoCarga, DbType.String, ParameterDirection.Input);
            parametros.Add("@tran_IdContenedor", item.tran_IdContenedor, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tran_FechaModificacion", item.tran_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarTransporte, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

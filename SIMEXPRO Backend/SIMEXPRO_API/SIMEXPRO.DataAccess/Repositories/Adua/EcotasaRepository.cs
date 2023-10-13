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
    public class EcotasaRepository : IRepository<tbEcotasa>
    {
        public RequestStatus Delete(tbEcotasa item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@ecot_Id", item.ecot_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarEcotasa, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbEcotasa Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEcotasa item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@ecot_RangoIncial", item.ecot_RangoIncial, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@ecot_RangoFinal", item.ecot_RangoFinal, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@ecot_CantidadPagar", item.ecot_CantidadPagar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ecot_FechaCreacion", item.ecot_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarEcotasa, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbEcotasa> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbEcotasa>(ScriptsDataBase.ListarEcotasa, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbEcotasa item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@ecot_Id", item.ecot_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ecot_RangoIncial", item.ecot_RangoIncial, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@ecot_RangoFinal", item.ecot_RangoFinal, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@ecot_CantidadPagar", item.ecot_CantidadPagar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ecot_FechaModificacion", item.ecot_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarEcotasa, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

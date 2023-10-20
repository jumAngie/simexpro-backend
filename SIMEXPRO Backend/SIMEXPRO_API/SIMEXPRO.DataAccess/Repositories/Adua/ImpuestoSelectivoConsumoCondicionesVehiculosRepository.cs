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
    public class ImpuestoSelectivoConsumoCondicionesVehiculosRepository : IRepository<tbImpuestoSelectivoConsumoCondicionesVehiculos>
    {
        public RequestStatus Delete(tbImpuestoSelectivoConsumoCondicionesVehiculos item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@selh_Id", item.selh_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarISCCV, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbImpuestoSelectivoConsumoCondicionesVehiculos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbImpuestoSelectivoConsumoCondicionesVehiculos item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@selh_EsNuevo", item.selh_EsNuevo, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@selh_RangoInicio", item.selh_RangoInicio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@selh_RangoFin", item.selh_RangoFin, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@selh_ImpuestoCobrar", item.selh_ImpuestoCobrar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@selh_FechaCreacion", item.selh_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarISCCV, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbImpuestoSelectivoConsumoCondicionesVehiculos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbImpuestoSelectivoConsumoCondicionesVehiculos>(ScriptsDataBase.ListarISCCV, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbImpuestoSelectivoConsumoCondicionesVehiculos item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@selh_Id", item.selh_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@selh_EsNuevo", item.selh_EsNuevo, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@selh_RangoInicio", item.selh_RangoInicio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@selh_RangoFin", item.selh_RangoFin, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@selh_ImpuestoCobrar", item.selh_ImpuestoCobrar, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@selh_FechaModificacion", item.selh_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarISCCV, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

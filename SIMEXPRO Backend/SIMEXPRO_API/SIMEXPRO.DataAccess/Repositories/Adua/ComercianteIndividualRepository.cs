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
    public class ComercianteIndividualRepository : IRepository<tbComercianteIndividual>
    {
        public RequestStatus Delete(tbComercianteIndividual item)
        {
            throw new NotImplementedException();
        }

        public tbComercianteIndividual Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbComercianteIndividual item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@pers_Id", item.pers_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fopr_Id", item.pers_FormaRepresentacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_Id", item.colo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferencia", item.coin_PuntoReferencia, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_ColoniaRepresentante", item.coin_ColoniaRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_NumeroLocalReprentante", item.coin_NumeroLocalReprentante, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferenciaReprentante", item.coin_PuntoReferenciaReprentante, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoCelular", item.coin_TelefonoCelular, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoFijo", item.coin_TelefonoFijo, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronico", item.coin_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronicoAlternativo", item.coin_CorreoElectronicoAlternativo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_FechaCreacion", item.coin_FechaCreacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarComercianteIndividual, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbComercianteIndividual> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbComercianteIndividual>(ScriptsDataBase.ListarComercianteIndividual, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbComercianteIndividual item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_Id", item.pers_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fopr_Id", item.pers_FormaRepresentacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_Id", item.colo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferencia", item.coin_PuntoReferencia, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_ColoniaRepresentante", item.coin_ColoniaRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_NumeroLocalReprentante", item.coin_NumeroLocalReprentante, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferenciaReprentante", item.coin_PuntoReferenciaReprentante, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoCelular", item.coin_TelefonoCelular, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoFijo", item.coin_TelefonoFijo, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronico", item.coin_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronicoAlternativo", item.coin_CorreoElectronicoAlternativo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_FechaModificacion", item.coin_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarComercianteIndividual, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus= answer;
            return result;
        }
    }
}

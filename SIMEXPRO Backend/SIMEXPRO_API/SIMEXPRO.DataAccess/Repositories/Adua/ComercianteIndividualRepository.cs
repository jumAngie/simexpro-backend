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
        public RequestStatus Delete(int coin_Id, int pers_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_Id", pers_Id, DbType.Int32, ParameterDirection.Input);
   

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EliminarComerciante, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus Finalizar(int coin_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", coin_Id, DbType.Int32, ParameterDirection.Input);


            var respuesta = db.QueryFirst<string>(ScriptsDataBase.FinalizarContratoComerciante, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }


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

            parametros.Add("@pers_RTN", item.pers_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pers_Nombre", item.pers_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@ofic_Id", item.ofic_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_Id", item.ofpr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FormaRepresentacion", item.pers_FormaRepresentacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@pers_escvRepresentante", item.pers_escvRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_OfprRepresentante", item.pers_OfprRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_FechaCreacion", item.coin_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarComercianteIndividual, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus InsertTap2(tbComercianteIndividual item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@alde_Id", item.alde_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@colo_Id", item.colo_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_NumeroLocalApart", item.coin_NumeroLocalApart, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferencia", item.coin_PuntoReferencia, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarComercianteIndividualTap2, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus InsertTap3(tbComercianteIndividual item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_CiudadRepresentante", item.coin_CiudadRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_AldeaRepresentante", item.coin_AldeaRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_coloniaIdRepresentante", item.coin_coloniaIdRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_NumeroLocaDepartRepresentante", item.coin_NumeroLocaDepartRepresentante, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_PuntoReferenciaReprentante", item.coin_PuntoReferenciaReprentante, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarComercianteIndividualTap3, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus InsertTap4(tbComercianteIndividual item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoCelular", item.coin_TelefonoCelular, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_TelefonoFijo", item.coin_TelefonoFijo, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronico", item.coin_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@coin_CorreoElectronicoAlternativo", item.coin_CorreoElectronicoAlternativo, DbType.String, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarComercianteIndividualTap4, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

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
            parametros.Add("@pers_RTN", item.pers_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pers_Nombre", item.pers_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@ofic_Id", item.ofic_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ofpr_Id", item.ofpr_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_FormaRepresentacion", item.pers_FormaRepresentacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@pers_escvRepresentante", item.pers_escvRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_OfprRepresentante", item.pers_OfprRepresentante, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@coin_FechaModificacion", item.coin_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarComercianteIndividual, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus= answer;
            return result;
        }
    }
}

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
    public class PersonaNaturalRepository : IRepository<tbPersonaNatural>
    {
        public RequestStatus Delete(tbPersonaNatural item)
        {
            throw new NotImplementedException();
        }

        public tbPersonaNatural Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPersonaNatural item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pers_Id", item.pers_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_DireccionExacta", item.pena_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_TelefonoFijo", item.pena_TelefonoFijo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_TelefonoCelular", item.pena_TelefonoCelular, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_CorreoElectronico", item.pena_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_CorreoAlternativo", item.pena_CorreoAlternativo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_RTN", item.pena_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoRTN", item.pena_ArchivoRTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_DNI", item.pena_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoDNI", item.pena_ArchivoDNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NumeroRecibo", item.pena_NumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoNumeroRecibo", item.pena_ArchivoNumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchRTN", item.pena_NombreArchRTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchRecibo", item.pena_NombreArchRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchDNI", item.pena_ArchivoNumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_FechaCreacion", item.pena_FechaCreacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarPersonaNatural, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbPersonaNatural> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbPersonaNatural>(ScriptsDataBase.ListarPersonaNatural, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbPersonaNatural item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pena_Id", item.pena_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pers_Id", item.pers_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_DireccionExacta", item.pena_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@ciud_Id", item.ciud_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_TelefonoFijo", item.pena_TelefonoFijo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_TelefonoCelular", item.pena_TelefonoCelular, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_CorreoElectronico", item.pena_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_CorreoAlternativo", item.pena_CorreoAlternativo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_RTN", item.pena_RTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoRTN", item.pena_ArchivoRTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_DNI", item.pena_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoDNI", item.pena_ArchivoDNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NumeroRecibo", item.pena_NumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_ArchivoNumeroRecibo", item.pena_ArchivoNumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchRTN", item.pena_NombreArchRTN, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchRecibo", item.pena_NombreArchRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@pena_NombreArchDNI", item.pena_ArchivoNumeroRecibo, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pena_FechaModificacion", item.pena_FechaModificacion, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarPersonaNatural, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
        public RequestStatus Finalizar(tbPersonaNatural item)
        {
            RequestStatus result = new();
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@pena_Id", item.pena_Id, DbType.Int32, ParameterDirection.Input);
         
            var answer = db.QueryFirst<string>(ScriptsDataBase.FinalizarPersonaNatural, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

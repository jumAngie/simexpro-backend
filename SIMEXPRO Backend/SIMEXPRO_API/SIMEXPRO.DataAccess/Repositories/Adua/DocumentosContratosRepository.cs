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
    public class DocumentosContratosRepository : IRepository<tbDocumentosContratos>
    {
        public RequestStatus Delete(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@doco_Id", item.doco_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosContratos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbDocumentosContratos Find(int? id)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<tbDocumentosContratos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDocumentosContratos>(ScriptsDataBase.ListarDocumentosContratos, null, commandType: CommandType.StoredProcedure);
        }

    

        public RequestStatus InsertDocumentosComerciante(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_URLImagen", item.doco_URLImagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_FechaCreacion", item.doco_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarDocumentosComerciante, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus InsertDocumentosPersonaJuridica(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@peju_Id", item.peju_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_URLImagen", item.doco_URLImagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_FechaCreacion", item.doco_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertDocumentosPersonaJuridica, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public IEnumerable<tbDocumentosContratos> CargarDocumentosJuridica(int id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@peju_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbDocumentosContratos>(ScriptsDataBase.CargarDocumentosPersonaJuridica, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbDocumentosContratos> CargarDocumetosComerciante(int id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@coin_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbDocumentosContratos>(ScriptsDataBase.CargarDocuemntosComerciante, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus EditarDocumentosComerciante(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", item.coin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_URLImagen", item.doco_URLImagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_FechaModificacion	", item.doco_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@FormaRepresentacion", item.FormaRepresentacion, DbType.Boolean, ParameterDirection.Input);
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarDocumentosComerciante, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus EditarDocuJuridica(tbDocumentosContratos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@peju_Id", item.peju_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@doco_URLImagen", item.doco_URLImagen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@peju_FechaCreacion", item.doco_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarDocumentosPersonaJuridica, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus EliminarDocumentosByPeju_Id(int id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@peju_Id", id, DbType.Int32, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosByPeju_Id, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }


        public RequestStatus EliminarDocumentosByCoin_Id(int id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();

            parametros.Add("@coin_Id", id, DbType.Int32, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EliminarDocumentosCoin_Id, parametros, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };

        }

        public RequestStatus Insert(tbDocumentosContratos item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbDocumentosContratos item)
        {
            throw new NotImplementedException();
        }
    }
}

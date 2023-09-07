using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.DataAccess.Context;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Adua
{
    public class DucaRepository : IRepository<tbDuca>
    {
        public RequestStatus Delete(tbDuca item)
        {
            throw new NotImplementedException();
        }

        public tbDuca Find(int? id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<tbDeclaraciones_Valor> ListadoDevaNoDuca()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDeclaraciones_Valor>(ScriptsDataBase.ListarDevaNoDuca, null, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus PreInsert()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            
            var respuesta = db.QueryFirst<string>(ScriptsDataBase.PreInsertDuca, null, commandType: CommandType.StoredProcedure);
            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }


        public RequestStatus Insert(tbDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_No_Correlativo_Referencia", item.duca_No_Correlativo_Referencia, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_AduanaRegistro", item.duca_AduanaRegistro, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_AduanaDestino", item.duca_AduanaDestino, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Regimen_Aduanero", item.duca_Regimen_Aduanero, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Modalidad", item.duca_Modalidad, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Clase", item.duca_Clase, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_FechaVencimiento", item.duca_FechaVencimiento, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@duca_Pais_Procedencia", item.duca_Pais_Procedencia, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Pais_Destino", item.duca_Pais_Destino, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Deposito_Aduanero", item.duca_Deposito_Aduanero, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Lugar_Desembarque", item.duca_Lugar_Desembarque, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Manifiesto", item.duca_Manifiesto, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Titulo", item.duca_Titulo, DbType.String, ParameterDirection.Input);

            parameters.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_FechaCreacion", item.duca_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarDucaTAP1, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus InsertTap2(tbDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);

            parameters.Add("@duca_Codigo_Declarante", item.duca_Codigo_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Numero_Id_Declarante", item.duca_Numero_Id_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_NombreSocial_Declarante", item.duca_NombreSocial_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_DomicilioFiscal_Declarante", item.duca_DomicilioFiscal_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Codigo_Transportista", item.duca_Codigo_Transportista, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Transportista_Nombre", item.duca_Transportista_Nombre, DbType.String, ParameterDirection.Input);
            parameters.Add("@motr_Id", item.motr_Id, DbType.Int32, ParameterDirection.Input);

            parameters.Add("@cont_NoIdentificacion", item.cont_NoIdentificacion, DbType.String, ParameterDirection.Input);
            parameters.Add("@cont_Licencia", item.cont_Licencia, DbType.String, ParameterDirection.Input);
            parameters.Add("@pais_IdExpedicion", item.pais_IdExpedicion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@cont_Nombre", item.cont_Nombre, DbType.String, ParameterDirection.Input);
            parameters.Add("@cont_Apellido", item.cont_Apellido, DbType.String, ParameterDirection.Input);
            parameters.Add("@pais_Id", item.Id_pais_transporte, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@marca_Id", item.Transporte_marca_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_IdUnidadTransporte", item.tran_IdUnidadTransporte, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_Chasis", item.tran_Chasis, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_Remolque", item.tran_Remolque, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_CantCarga", item.tran_CantCarga, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_NumDispositivoSeguridad", item.tran_NumDispositivoSeguridad, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_Equipamiento", item.tran_Equipamiento, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_TamanioEquipamiento", item.tran_TamanioEquipamiento, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_TipoCarga", item.tran_TipoCarga, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_IdContenedor", item.tran_IdContenedor, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_FechaCreacion", item.duca_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarDucaTAP2, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus InsertTap3(tbDocumentosDeSoporte item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@tido_Id", item.tido_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_NumeroDocumento", item.doso_NumeroDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_FechaEmision", item.doso_FechaEmision, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@doso_FechaVencimiento", item.doso_FechaVencimiento, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@doso_PaisEmision", item.doso_PaisEmision, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_LineaAplica", item.doso_LineaAplica, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_EntiadEmitioDocumento", item.doso_EntidadEmitioDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_Monto", item.doso_Monto, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioCreacio", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_FechaCreacion", item.doso_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarDucaTAP3, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbDuca> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            return db.Query<tbDuca>(ScriptsDataBase.ListarDuca, null, commandType: System.Data.CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_No_Duca", item.duca_No_Duca, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_No_Correlativo_Referencia", item.duca_No_Correlativo_Referencia, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_AduanaRegistro", item.duca_AduanaRegistro, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_AduanaDestino", item.duca_AduanaDestino, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Regimen_Aduanero", item.duca_Regimen_Aduanero, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Modalidad", item.duca_Modalidad, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Clase", item.duca_Clase, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_FechaVencimiento", item.duca_FechaVencimiento, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@duca_Pais_Procedencia", item.duca_Pais_Procedencia, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Pais_Destino", item.duca_Pais_Destino, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Deposito_Aduanero", item.duca_Deposito_Aduanero, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Lugar_Desembarque", item.duca_Lugar_Desembarque, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Manifiesto", item.duca_Manifiesto, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Titulo", item.duca_Titulo, DbType.String, ParameterDirection.Input);

            parameters.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_FechaModificacion", item.duca_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarDucaTAP1, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus UpdateTap2(tbDuca item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@duca_Id", item.duca_Id, DbType.Int32, ParameterDirection.Input);

            parameters.Add("@duca_Codigo_Declarante", item.duca_Codigo_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Numero_Id_Declarante", item.duca_Numero_Id_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_NombreSocial_Declarante", item.duca_NombreSocial_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_DomicilioFiscal_Declarante", item.duca_DomicilioFiscal_Declarante, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Codigo_Transportista", item.duca_Codigo_Transportista, DbType.String, ParameterDirection.Input);
            parameters.Add("@duca_Transportista_Nombre", item.duca_Transportista_Nombre, DbType.String, ParameterDirection.Input);
            parameters.Add("@motr_Id", item.motr_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_Conductor_Id", item.duca_Conductor_Id, DbType.Int32, ParameterDirection.Input);

            parameters.Add("@cont_NoIdentificacion", item.cont_NoIdentificacion, DbType.String, ParameterDirection.Input);
            parameters.Add("@cont_Licencia", item.cont_Licencia, DbType.String, ParameterDirection.Input);
            parameters.Add("@pais_IdExpedicion", item.pais_IdExpedicion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@cont_Nombre", item.cont_Nombre, DbType.String, ParameterDirection.Input);
            parameters.Add("@cont_Apellido", item.cont_Apellido, DbType.String, ParameterDirection.Input);
            parameters.Add("@pais_Id", item.Id_pais_transporte, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@marca_Id", item.Transporte_marca_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_IdUnidadTransporte", item.tran_IdUnidadTransporte, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_Chasis", item.tran_Chasis, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_Remolque", item.tran_Remolque, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_CantCarga", item.tran_CantCarga, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_NumDispositivoSeguridad", item.tran_NumDispositivoSeguridad, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tran_Equipamiento", item.tran_Equipamiento, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_TamanioEquipamiento", item.tran_TamanioEquipamiento, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_TipoCarga", item.tran_TipoCarga, DbType.String, ParameterDirection.Input);
            parameters.Add("@tran_IdContenedor", item.tran_IdContenedor, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@duca_FechaModificacion", item.duca_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarDucaTAP2, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus UpdateTap3(tbDocumentosDeSoporte item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parameters = new DynamicParameters();

            parameters.Add("@doso_Id", item.doso_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@tido_Id", item.tido_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_NumeroDocumento", item.doso_NumeroDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_FechaEmision", item.doso_FechaEmision, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@doso_FechaVencimiento", item.doso_FechaVencimiento, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@doso_PaisEmision", item.doso_PaisEmision, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_LineaAplica", item.doso_LineaAplica, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_EntiadEmitioDocumento", item.doso_EntidadEmitioDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("@doso_Monto", item.doso_Monto, DbType.String, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@doso_FechaModificacion", item.doso_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarDucaTAP3, parameters, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public RequestStatus FinalizarDuca(int duca_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@duca_Id", duca_Id, DbType.Int32, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.FinalizarDuca, parametros, commandType: CommandType.StoredProcedure);
            
            return new RequestStatus() 
            { 
                CodeStatus = answer != "1" ? 0 : int.Parse(answer),
                MessageStatus = answer
            };
        }
    }
}

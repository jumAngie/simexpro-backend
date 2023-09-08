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
    public class OrdenCompraDetallesRepository : IRepository<tbOrdenCompraDetalles>
    {
        public RequestStatus Delete(tbOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbOrdenCompraDetalles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_CantidadPrenda", item.code_CantidadPrenda, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_Id", item.esti_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tall_Id", item.tall_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Sexo", item.code_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@colr_Id", item.colr_Id, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@code_Documento", item.code_Documento, DbType.String, ParameterDirection.Input);
            //parametros.Add("@code_Medidas", item.code_Medidas, DbType.String, ParameterDirection.Input);
            parametros.Add("@proc_IdComienza", item.proc_IdComienza, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@proc_IdActual", item.proc_IdActual, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Unidad", item.code_Unidad, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@code_Valor", item.code_Valor, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@code_Impuesto", item.code_Impuesto, DbType.Decimal, ParameterDirection.Input);
            //parametros.Add("@code_Descuento", item.code_Descuento, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@code_EspecificacionEmbalaje", item.code_EspecificacionEmbalaje, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_FechaCreacion", item.code_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            //parametros.Add("@code_CodigoDetalle", item.code_CodigoDetalle, DbType.String, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbOrdenCompraDetalles> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbOrdenCompraDetalles> ListByIdOrdenCompra(int orco_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", orco_Id, DbType.Int32, ParameterDirection.Input);
            var result = db.Query<tbOrdenCompraDetalles>(ScriptsDataBase.ListarOrdenCompraDetalles, parametros, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbOrdenCompraDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@orco_Id", item.orco_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_CantidadPrenda", item.code_CantidadPrenda, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@esti_Id", item.esti_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@tall_Id", item.tall_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Sexo", item.code_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@colr_Id", item.colr_Id, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@code_Documento", item.code_Documento, DbType.String, ParameterDirection.Input);
            //parametros.Add("@code_Medidas", item.code_Medidas, DbType.String, ParameterDirection.Input);
            parametros.Add("@proc_IdComienza", item.proc_IdComienza, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@proc_IdActual", item.proc_IdActual, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Unidad", item.code_Unidad, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@code_Valor", item.code_Valor, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@code_Impuesto", item.code_Impuesto, DbType.Decimal, ParameterDirection.Input);
            //parametros.Add("@code_Descuento", item.code_Descuento, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@code_EspecificacionEmbalaje", item.code_EspecificacionEmbalaje, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_FechaModificacion", item.code_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarOrdenCompraDetalles, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<VW_tbOrdenCompraDetalle_LineaTiempo> LineaTiempoOrdenCompraDetalles(int orco_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@orco_Id", orco_Id, DbType.Int32, ParameterDirection.Input);

            return db.Query<VW_tbOrdenCompraDetalle_LineaTiempo>(ScriptsDataBase.ObtenerDetallesPorIdCompraParaLineaTiempo, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}

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
    public class BaseCalculosRepository : IRepository<tbBaseCalculos>
    {
        public RequestStatus Delete(tbBaseCalculos item)
        {
            throw new NotImplementedException();

        }

        public tbBaseCalculos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbBaseCalculos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@base_PrecioFactura ", item.base_PrecioFactura, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_PagosIndirectos", item.base_PagosIndirectos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_PrecioReal ", item.base_PrecioReal, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_MontCondicion ", item.base_MontCondicion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_MontoReversion", item.base_MontoReversion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_ComisionCorrelaje", item.base_ComisionCorrelaje, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gasto_Envase_Embalaje", item.base_Gasto_Envase_Embalaje, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_ValoresMateriales_Incorporado", item.base_ValoresMateriales_Incorporado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Materiales_Utilizados", item.base_Valor_Materiales_Utilizados, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Materiales_Consumidos", item.base_Valor_Materiales_Consumidos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Ingenieria_Importado", item.base_Valor_Ingenieria_Importado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Canones ", item.base_Valor_Canones, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gasto_TransporteM_Importada", item.base_Gasto_TransporteM_Importada, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Carga_Importada ", item.base_Gastos_Carga_Importada, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Costos_Seguro", item.base_Costos_Seguro, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Total_Ajustes_Precio_Pagado", item.base_Total_Ajustes_Precio_Pagado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Asistencia_Tecnica", item.base_Gastos_Asistencia_Tecnica, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Transporte_Posterior", item.base_Gastos_Transporte_Posterior, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Derechos_Impuestos", item.base_Derechos_Impuestos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Monto_Intereses", item.base_Monto_Intereses, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Deducciones_Legales", item.base_Deducciones_Legales, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Total_Deducciones_Precio ", item.base_Total_Deducciones_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Aduana", item.base_Valor_Aduana, DbType.Decimal, ParameterDirection.Input);

            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@base_FechaCreacion", item.base_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarBaseCalculos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbBaseCalculos> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbBaseCalculos>(ScriptsDataBase.ListarBaseCalculos, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbBaseCalculos item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@base_Id", item.base_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@base_PrecioFactura ", item.base_PrecioFactura, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_PagosIndirectos", item.base_PagosIndirectos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_PrecioReal ", item.base_PrecioReal, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_MontCondicion ", item.base_MontCondicion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_MontoReversion", item.base_MontoReversion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_ComisionCorrelaje", item.base_ComisionCorrelaje, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gasto_Envase_Embalaje", item.base_Gasto_Envase_Embalaje, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_ValoresMateriales_Incorporado", item.base_ValoresMateriales_Incorporado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Materiales_Utilizados", item.base_Valor_Materiales_Utilizados, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Materiales_Consumidos", item.base_Valor_Materiales_Consumidos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Ingenieria_Importado", item.base_Valor_Ingenieria_Importado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Canones ", item.base_Valor_Canones, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gasto_TransporteM_Importada", item.base_Gasto_TransporteM_Importada, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Carga_Importada ", item.base_Gastos_Carga_Importada, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Costos_Seguro", item.base_Costos_Seguro, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Total_Ajustes_Precio_Pagado", item.base_Total_Ajustes_Precio_Pagado, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Asistencia_Tecnica", item.base_Gastos_Asistencia_Tecnica, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Gastos_Transporte_Posterior", item.base_Gastos_Transporte_Posterior, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Derechos_Impuestos", item.base_Derechos_Impuestos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Monto_Intereses", item.base_Monto_Intereses, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Deducciones_Legales", item.base_Deducciones_Legales, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Total_Deducciones_Precio ", item.base_Total_Deducciones_Precio, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@base_Valor_Aduana", item.base_Valor_Aduana, DbType.Decimal, ParameterDirection.Input);

            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@base_FechaModificacion", item.base_FechaModificacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarBaseCalculos, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

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
    public class CondicionesRepository : IRepository<tbCondiciones>
    {
        public RequestStatus Delete(tbCondiciones item)
        {
            throw new NotImplementedException();
        }

        public tbCondiciones Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCondiciones item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@codi_Restricciones_Utilizacion", item.codi_Restricciones_Utilizacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Restricciones_Utilizacion", item.codi_Indicar_Restricciones_Utilizacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Depende_Precio_Condicion", item.codi_Depende_Precio_Condicion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Existe_Condicion", item.codi_Indicar_Existe_Condicion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Condicionada_Revertir", item.codi_Condicionada_Revertir, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Vinculacion_Comprador_Vendedor", item.codi_Vinculacion_Comprador_Vendedor, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Tipo_Vinculacion", item.codi_Tipo_Vinculacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Vinculacion_Influye_Precio", item.codi_Vinculacion_Influye_Precio, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Pagos_Descuentos_Indirectos", item.codi_Pagos_Descuentos_Indirectos, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Concepto_Monto_Declarado", item.codi_Concepto_Monto_Declarado, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Existen_Canones", item.codi_Existen_Canones, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Canones", item.codi_Indicar_Canones, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@codi_FechaCreacion", item.codi_FechaCreacion, DbType.DateTime, ParameterDirection.Input);    
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarCondiciones, parametros, commandType: CommandType.StoredProcedure);

            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbCondiciones> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbCondiciones>(ScriptsDataBase.ListarCondiciones, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCondiciones item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@codi_Id", item.codi_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@deva_Id", item.deva_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@codi_Restricciones_Utilizacion", item.codi_Restricciones_Utilizacion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Restricciones_Utilizacion", item.codi_Indicar_Restricciones_Utilizacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Depende_Precio_Condicion", item.codi_Depende_Precio_Condicion, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Existe_Condicion", item.codi_Indicar_Existe_Condicion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Condicionada_Revertir", item.codi_Condicionada_Revertir, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Vinculacion_Comprador_Vendedor", item.codi_Vinculacion_Comprador_Vendedor, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Tipo_Vinculacion", item.codi_Tipo_Vinculacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Vinculacion_Influye_Precio", item.codi_Vinculacion_Influye_Precio, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Pagos_Descuentos_Indirectos", item.codi_Pagos_Descuentos_Indirectos, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Concepto_Monto_Declarado", item.codi_Concepto_Monto_Declarado, DbType.String, ParameterDirection.Input);
            parametros.Add("@codi_Existen_Canones", item.codi_Existen_Canones, DbType.Boolean, ParameterDirection.Input);
            parametros.Add("@codi_Indicar_Canones", item.codi_Indicar_Canones, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@codi_FechaCreacion", item.codi_FechaCreacion, DbType.DateTime, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarCondiciones, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

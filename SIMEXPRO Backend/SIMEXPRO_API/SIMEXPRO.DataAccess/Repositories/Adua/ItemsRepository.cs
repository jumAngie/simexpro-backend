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
    public class ItemsRepository : IRepository<tbItems>
    {
        public RequestStatus Delete(tbItems item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_FechaEliminacion", item.item_FechaEliminacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarItems, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbItems Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbItems item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@fact_Id", item.fact_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_Cantidad", item.item_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_PesoNeto", item.item_PesoNeto, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_PesoBruto", item.item_PesoBruto, DbType.String, ParameterDirection.Input);
            parametros.Add("@unme_Id", item.unme_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_IdentificacionComercialMercancias", item.item_IdentificacionComercialMercancias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_CaracteristicasMercancias", item.item_CaracteristicasMercancias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Marca", item.item_Marca, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Modelo", item.item_Modelo, DbType.String, ParameterDirection.Input);
            parametros.Add("@merc_Id", item.merc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_IdOrigenMercancia", item.pais_IdOrigenMercancia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_ClasificacionArancelaria", item.item_ClasificacionArancelaria, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_ValorUnitario", item.item_ValorUnitario, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_GastosDeTransporte", item.item_GastosDeTransporte, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ValorTransaccion", item.item_ValorTransaccion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_Seguro", item.item_Seguro, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_OtrosGastos", item.item_OtrosGastos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ValorAduana", item.item_ValorAduana, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_CuotaContingente", item.item_CuotaContingente, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ReglasAccesorias", item.item_ReglasAccesorias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_CriterioCertificarOrigen", item.item_CriterioCertificarOrigen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_FechaCreacion", item.item_FechaCreacion, DbType.String, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarItems, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbItems> List(int fact_Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@fact_Id", fact_Id, DbType.Int32, ParameterDirection.Input);

            return db.Query<tbItems>(ScriptsDataBase.ListarItems, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbItems> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbItems item)
        {
            RequestStatus result = new();

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@item_Id", item.item_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fact_Id", item.fact_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_Cantidad", item.item_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_PesoNeto", item.item_PesoNeto, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_PesoBruto", item.item_PesoBruto, DbType.String, ParameterDirection.Input);
            parametros.Add("@unme_Id", item.unme_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_IdentificacionComercialMercancias", item.item_IdentificacionComercialMercancias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_CaracteristicasMercancias", item.item_CaracteristicasMercancias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Marca", item.item_Marca, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_Modelo", item.item_Modelo, DbType.String, ParameterDirection.Input);
            parametros.Add("@merc_Id", item.merc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pais_IdOrigenMercancia", item.pais_IdOrigenMercancia, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_ClasificacionArancelaria", item.item_ClasificacionArancelaria, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_ValorUnitario", item.item_ValorUnitario, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_GastosDeTransporte", item.item_GastosDeTransporte, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ValorTransaccion", item.item_ValorTransaccion, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_Seguro", item.item_Seguro, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_OtrosGastos", item.item_OtrosGastos, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ValorAduana", item.item_ValorAduana, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_CuotaContingente", item.item_CuotaContingente, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@item_ReglasAccesorias", item.item_ReglasAccesorias, DbType.String, ParameterDirection.Input);
            parametros.Add("@item_CriterioCertificarOrigen", item.item_CriterioCertificarOrigen, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@item_FechaModificacion", item.item_FechaModificacion, DbType.String, ParameterDirection.Input);


            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarItems, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}
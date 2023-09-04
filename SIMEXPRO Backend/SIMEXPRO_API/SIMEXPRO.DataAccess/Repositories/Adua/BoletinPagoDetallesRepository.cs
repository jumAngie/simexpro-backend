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
    public class BoletinPagoDetallesRepository : IRepository<tbBoletinPagoDetalles>
    {
        public RequestStatus Delete(tbBoletinPagoDetalles item)
        {
            throw new NotImplementedException();
        }

        public tbBoletinPagoDetalles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbBoletinPagoDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@boen_Id", item.boen_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@lige_Id", item.lige_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@bode_Concepto", item.bode_Concepto, DbType.String, ParameterDirection.Input);
            parametros.Add("@bode_TipoObligacion", item.bode_TipoObligacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@bode_CuentaPA01", item.bode_CuentaPA01, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@bode_FechaCreacion", item.bode_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.InsertarBoletinPagoDetalles, parametros, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }

        public IEnumerable<tbBoletinPagoDetalles> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbBoletinPagoDetalles> ListByIdBoletinPago(int Id)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@boen_Id", Id, DbType.Int32, ParameterDirection.Input);

            return db.Query<tbBoletinPagoDetalles>(ScriptsDataBase.ListarBoletinPagoDetallesByIdBoletin, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbBoletinPagoDetalles item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@bode_Id", item.bode_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@boen_Id", item.boen_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@lige_Id", item.lige_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@bode_Concepto", item.bode_Concepto, DbType.String, ParameterDirection.Input);
            parametros.Add("@bode_TipoObligacion", item.bode_TipoObligacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@bode_CuentaPA01", item.bode_CuentaPA01, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@bode_FechaCreacion", item.bode_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var respuesta = db.QueryFirst<string>(ScriptsDataBase.EditarBoletinPagoDetalles, parametros, commandType: CommandType.StoredProcedure);

            return new RequestStatus()
            {
                MessageStatus = respuesta
            };
        }
    }
}

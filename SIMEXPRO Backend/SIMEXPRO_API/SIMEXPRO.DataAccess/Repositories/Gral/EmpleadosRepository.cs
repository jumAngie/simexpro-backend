using Dapper;
using Microsoft.Data.SqlClient;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess.Repositories.Gral
{
    public class EmpleadosRepository : IRepository<tbEmpleados>
    {
        public RequestStatus Delete(tbEmpleados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_FechaEliminacion", item.empl_FechaEliminacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EliminarEmpleados, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public tbEmpleados Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEmpleados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@empl_Nombres", item.empl_Nombres, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Apellidos", item.empl_Apellidos, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_DNI", item.empl_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Sexo", item.empl_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_FechaNacimiento", item.empl_FechaNacimiento, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Telefono", item.empl_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_DireccionExacta", item.empl_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@pvin_Id", item.pvin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_CorreoElectronico", item.empl_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_EsAduana", item.empl_EsAduana, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_FechaCreacion", item.empl_FechaCreacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarEmpleados, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbEmpleados> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbEmpleados>(ScriptsDataBase.ListarEmpleados, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbEmpleados> List(bool? empl_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@empl_EsAduana", empl_EsAduana, DbType.Boolean, ParameterDirection.Input);

            return db.Query<tbEmpleados>(ScriptsDataBase.ListarEmpleados, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbEmpleados> ListNoTieneUsuario(bool? empl_EsAduana)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@empl_EsAduana", empl_EsAduana, DbType.Boolean, ParameterDirection.Input);

            return db.Query<tbEmpleados>(ScriptsDataBase.ListarEmpleadosSinUsuario, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbEmpleados item)
        {

            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Nombres", item.empl_Nombres, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Apellidos", item.empl_Apellidos, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_DNI", item.empl_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@escv_Id", item.escv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Sexo", item.empl_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_FechaNacimiento", item.empl_FechaNacimiento, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Telefono", item.empl_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_DireccionExacta", item.empl_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@pvin_Id", item.pvin_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_CorreoElectronico", item.empl_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_EsAduana", item.empl_EsAduana, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_FechaModificacion", item.empl_FechaModificacion, DbType.String, ParameterDirection.Input);
            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarEmpleados, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }


        public RequestStatus Reactivar(tbEmpleados item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new();
            var parameters = new DynamicParameters();
            parameters.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@usua_UsuarioActivacion", item.usua_UsuarioActivacion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@empl_FechaActivacion", item.empl_FechaActivacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.ReactivarEmpleados, parameters, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;

            return result;
        }
    }
}

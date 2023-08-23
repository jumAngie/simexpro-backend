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
    public class Orde_Ensa_Acab_EtiqRepository : IRepository<tbOrde_Ensa_Acab_Etiq>
    {
        public RequestStatus Delete(tbOrde_Ensa_Acab_Etiq item)
        {
            throw new NotImplementedException();

        }

        public tbOrde_Ensa_Acab_Etiq Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbOrde_Ensa_Acab_Etiq item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ensa_Cantidad", item.ensa_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_FechaInicio", item.ensa_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ensa_FechaLimite", item.ensa_FechaLimite, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioCreacion", item.usua_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_FechaCreacion", item.ensa_FechaCreacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.InsertarOrde_Ensa_Acab_Etiq, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }

        public IEnumerable<tbOrde_Ensa_Acab_Etiq> List()
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            var result = db.Query<tbOrde_Ensa_Acab_Etiq>(ScriptsDataBase.ListarOrde_Ensa_Acab_Etiq, null, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public RequestStatus Update(tbOrde_Ensa_Acab_Etiq item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);
            RequestStatus result = new RequestStatus();
            var parametros = new DynamicParameters();
            parametros.Add("@ensa_Id", item.ensa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_Cantidad", item.ensa_Cantidad, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@code_Id", item.code_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_FechaInicio", item.ensa_FechaInicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ensa_FechaLimite", item.ensa_FechaLimite, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@ppro_Id", item.ppro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@modu_Id", item.modu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioModificacion", item.usua_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@ensa_FechaModificacion", item.ensa_FechaModificacion, DbType.DateTime, ParameterDirection.Input);

            var answer = db.QueryFirst<string>(ScriptsDataBase.EditarOrde_Ensa_Acab_Etiq, parametros, commandType: CommandType.StoredProcedure);
            result.MessageStatus = answer;
            return result;
        }
    }
}

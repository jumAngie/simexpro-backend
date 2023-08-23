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
    public class IntermediarioRepository : IRepository<tbIntermediarios>
    {
        public RequestStatus Delete(tbIntermediarios item)
        {
            using var db = new SqlConnection(SIMEXPRO.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@inte_Id", item.inte_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_UsuarioEliminacion", item.usua_UsuarioEliminacion, DbType.String, ParameterDirection.Input);
            parametros.Add("@inte_FechaEliminacion", item.inte_FechaEliminacion, DbType.String, ParameterDirection.Input);

            var resultado = db.QueryFirst<string>(ScriptsDataBase.IniciarSesion, parametros, commandType: CommandType.StoredProcedure);
            RequestStatus requestStatus = new RequestStatus()
            {
                MessageStatus = resultado
            };
            return requestStatus;
        }

        public tbIntermediarios Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbIntermediarios item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbIntermediarios> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbIntermediarios item)
        {
            throw new NotImplementedException();
        }
    }
}

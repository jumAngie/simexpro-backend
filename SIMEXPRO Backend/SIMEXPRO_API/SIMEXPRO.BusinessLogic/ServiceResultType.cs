using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.BussinessLogic
{
    public enum ServiceResultType
    {
        info = 100,
        Success = 200,
        Warning = 202,
        BadRecuest = 400,
        Unauthorize = 401,
        Forbidden = 203,
        NotFound = 404,
        NotAcceptable = 406,
        Conflict = 409,
        Disabled = 410,
        Error = 500,
        BadRequest = 501,
        Unauthorized = 502,
        Info = 503
    }
}

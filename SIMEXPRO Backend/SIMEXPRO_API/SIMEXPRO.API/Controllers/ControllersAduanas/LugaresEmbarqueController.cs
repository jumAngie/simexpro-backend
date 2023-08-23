using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.Entities.Entities;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresEmbarqueController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public LugaresEmbarqueController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(String codigo)
        {
            var respuesta = _aduanaServices.ListarLugaresEmbarque(codigo);
            respuesta.Data = _mapper.Map<IEnumerable<LugaresEmbarqueViewModel>>(respuesta.Data);
            return Ok(respuesta);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(LugaresEmbarqueViewModel concepto)
        {
            var item = _mapper.Map<tbLugaresEmbarque>(concepto);

            var respuesta = _aduanaServices.InsertarLugaresEmbarque(item);

            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(LugaresEmbarqueViewModel concepto)
        {
            var item = _mapper.Map<tbLugaresEmbarque>(concepto);

            var respuesta = _aduanaServices.ActualizarLugaresEmbarque(item);

            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(LugaresEmbarqueViewModel concepto)
        {
            var item = _mapper.Map<tbLugaresEmbarque>(concepto);

            var respuesta = _aduanaServices.EliminarLugaresEmbarque(item);

            return Ok(respuesta);
        }
    }
}

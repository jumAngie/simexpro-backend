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

    public class LiquidacionPorLineaController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public LiquidacionPorLineaController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarLiquidacionPorLinea();
            respuesta.Data = _mapper.Map<IEnumerable<LiquidacionPorLineaViewModel>>(respuesta.Data);
            return Ok(respuesta);

        }

        [HttpPost("Insertar")]
        public IActionResult Insert(LiquidacionPorLineaViewModel concepto)
        {
            var item = _mapper.Map<tbLiquidacionPorLinea>(concepto);

            var respuesta = _aduanaServices.InsertarLiquidacionPorLinea(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        [HttpPost("Editar")]
        public IActionResult Update(LiquidacionPorLineaViewModel concepto)
        {
            var item = _mapper.Map<tbLiquidacionPorLinea>(concepto);

            var respuesta = _aduanaServices.ActualizarLiquidacionPorLinea(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }
    }
}

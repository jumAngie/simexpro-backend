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
    public class LiquidacionGeneralController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public LiquidacionGeneralController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarLiquidacionGeneral();
            respuesta.Data = _mapper.Map<IEnumerable<LiquidacionGeneralViewModel>>(respuesta.Data);
            return Ok(respuesta);

        }

        [HttpPost("Insertar")]
        public IActionResult Insert(LiquidacionGeneralViewModel concepto)
        {
            var item = _mapper.Map<tbLiquidacionGeneral>(concepto);

            var respuesta = _aduanaServices.InsertarLiquidacionGeneral(item);

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
        public IActionResult Update(LiquidacionGeneralViewModel concepto)
        {
            var item = _mapper.Map<tbLiquidacionGeneral>(concepto);

            var respuesta = _aduanaServices.ActualizarLiquidacionGeneral(item);

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

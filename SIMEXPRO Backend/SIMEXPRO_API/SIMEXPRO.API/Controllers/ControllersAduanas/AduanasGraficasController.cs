using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsProduccion;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AduanasGraficasController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public AduanasGraficasController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("ExportadoresPorPais_CantidadPorcentaje")]
        public IActionResult ExportadoresPorPais_CantidadPorcentaje()
        {
            var listado = _aduanaServices.ExportadoresPorPais_CantidadPorcentaje();
            return Ok(listado);
        }

        [HttpGet("EstadosMercancias_CantidadPorcentaje")]
        public IActionResult EstadosMercancias_CantidadPorcentaje()
        {
            var listado = _aduanaServices.EstadosMercancias_CantidadPorcentaje();
            return Ok(listado);
        }

    }
}

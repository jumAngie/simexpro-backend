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

        [HttpGet("AduanasIngreso_CantidadPorcentaje")]
        public IActionResult AduanasIngreso_CantidadPorcentaje()
        {
            var listado = _aduanaServices.AduanasIngreso_CantidadPorcentaje();
            return Ok(listado);
        }

        [HttpGet("Importaciones_Contador_Anio")]
        public IActionResult Importaciones_Contador_Anio()
        {
            var listado = _aduanaServices.Importaciones_Contador_Anio();
            return Ok(listado);
        }

        [HttpGet("Importaciones_Contador_Mes")]
        public IActionResult Importaciones_Contador_Mes()
        {
            var listado = _aduanaServices.Importaciones_Contador_Mes(); 
            return Ok(listado);
        }

        [HttpGet("Importaciones_Contador_Semana")]
        public IActionResult Importaciones_Contador_Semana()
        {
            var listado = _aduanaServices.Importaciones_Contador_Semana();
            return Ok(listado);
        }

        [HttpGet("Importaciones_Semana")]
        public IActionResult Importaciones_Semana()
        {
            var listado = _aduanaServices.Importaciones_Semana();
            return Ok(listado);
        }

        [HttpGet("Importaciones_Mes")]
        public IActionResult Importaciones_Mes()
        {
            var listado = _aduanaServices.Importaciones_Mes();
            return Ok(listado);
        }

        [HttpGet("Importaciones_Anio")]
        public IActionResult Importaciones_Anio()
        {
            var listado = _aduanaServices.Importaciones_Anio();
            return Ok(listado);
        }

        [HttpGet("RegimenesAduaneros_CantidadPorcentaje")]
        public IActionResult RegimenesAduaneros_CantidadPorcentaje()
        {
            var listado = _aduanaServices.RegimenesAduaneros_CantidadPorcentaje();
            return Ok(listado);
        }
    }
}

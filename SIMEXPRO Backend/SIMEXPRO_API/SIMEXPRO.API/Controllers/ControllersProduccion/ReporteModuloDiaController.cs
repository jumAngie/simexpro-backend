using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsProduccion;
using SIMEXPRO.BussinessLogic.Services.ProduccionServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersProduccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteModuloDiaController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ReporteModuloDiaController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarReporteModuloDia();
            listado.Data = _mapper.Map<IEnumerable<ReporteModuloDiaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("ListarPorFecha")]
        public IActionResult IndexPorFecha(DateTime? FechaInicio, DateTime? FechaFin)
        {
            var listado = _produccionServices.ListarReporteModuloDiaPorFechas(FechaInicio, FechaFin);
            listado.Data = _mapper.Map<IEnumerable<ReporteModuloDiaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ReporteModuloDiaViewModel ReporteModuloDiaViewModel)
        {
            var item = _mapper.Map<tbReporteModuloDia>(ReporteModuloDiaViewModel);
            var respuesta = _produccionServices.InsertarReporteModuloDia(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Editar(ReporteModuloDiaViewModel ReporteModuloDiaViewModel)
        {
            var item = _mapper.Map<tbReporteModuloDia>(ReporteModuloDiaViewModel);
            var respuesta = _produccionServices.ActualizarReporteModuloDia(item);
            return Ok(respuesta);
        }

        [HttpPost("Finalizar")]
        public IActionResult Finalizar(ReporteModuloDiaViewModel ReporteModuloDiaViewModel)
        {
            var item = _mapper.Map<tbReporteModuloDia>(ReporteModuloDiaViewModel);
            var respuesta = _produccionServices.FinalizarReporteModuloDia(item);
            return Ok(respuesta);
        }


    }
}

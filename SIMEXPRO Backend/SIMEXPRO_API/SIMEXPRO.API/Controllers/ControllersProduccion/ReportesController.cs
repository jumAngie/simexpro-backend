using AutoMapper;
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
    public class ReportesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ReportesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpPost("TiemposMaquinas")]
        public IActionResult maquinasTiempo(ReportesViewModel reporte)
        {
            var data = _mapper.Map<tbReportes>(reporte);
            var listado = _produccionServices.TiemposMaquinas(data);
            return Ok(listado);
        }
        
        [HttpPost("ProduccionPorModulo")]
        public IActionResult ModuloProduccion(ReportesViewModel reporte)
        {
            var data = _mapper.Map<tbReportes>(reporte);
            var listado = _produccionServices.ModuloProduccion(data);
            return Ok(listado);
        }

        [HttpPost("PedidosCliente")]
        public IActionResult PedidosCliente(ReportesViewModel reporte)
        {
            var data = _mapper.Map<tbReportes>(reporte);
            var listado = _produccionServices.PedidosCliente(data);
            return Ok(listado);
        }

        [HttpPost("PlanificacionPO")]
        public IActionResult PlanificacionPO(ReportesViewModel reporte)
        {
            var listado = _produccionServices.PlanificacionPO(reporte.orco_Id);
            return Ok(listado);
        }

    }
}

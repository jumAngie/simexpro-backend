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
    public class GraficasController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public GraficasController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpPost("AvanceOrdenCompra")]
        public IActionResult AvanceOrdenCompra(GraficasViewModel item)
        {
            var data = _mapper.Map<tbGraficas>(item);
            var listado = _produccionServices.Avance_Orden_Compra(data);
            return Ok(listado);
        }

        [HttpGet("TotalOrdenesCompraAnual")]
        public IActionResult TotalOrdenesCompraAnual()
        {
            var listado = _produccionServices.TotalOrdenesCompraAnual();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("TotalOrdenesCompraMensual")]
        public IActionResult TotalOrdenesCompraMensual()
        {
            var listado = _produccionServices.TotalOrdenesCompraMensual();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("TotalOrdenesCompraDiario")]
        public IActionResult TotalOrdenesCompraDiario()
        {
            var listado = _produccionServices.TotalOrdenesCompraDiario();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("ContadorOrdenesCompraPorEstado")]
        public IActionResult ContadorOrdenesCompraPorEstado()
        {
            var listado = _produccionServices.ContadorOrdenesCompraPorEstado();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }        
        
        [HttpGet("ContadorOrdenesCompraPorEstado_UltimaSemana")]
        public IActionResult ContadorOrdenesCompraPorEstado_UltimaSemana()
        {
            var listado = _produccionServices.ContadorOrdenesCompraPorEstado_UltimaSemana();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }        
        
        [HttpGet("VentasSemanales")]
        public IActionResult VentasSemanales()
        {
            var listado = _produccionServices.VentasSemanales();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }        
        
        [HttpGet("VentasMensuales")]
        public IActionResult VentasMensuales()
        {
            var listado = _produccionServices.VentasMensuales();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }        
        
        [HttpGet("VentasAnuales")]
        public IActionResult VentasAnuales()
        {
            var listado = _produccionServices.VentasAnuales();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }        
        
        [HttpGet("OrdenenesEntregadasPendientes_Anual")]
        public IActionResult OrdenenesEntregadasPendientes_Anual()
        {
            var listado = _produccionServices.OrdenenesEntregadasPendientes_Anual();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }
        
        [HttpGet("OrdenenesEntregadasPendientes_Mensual")]
        public IActionResult OrdenenesEntregadasPendientes_Mensual()
        {
            var listado = _produccionServices.OrdenenesEntregadasPendientes_Mensual();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }
        
        [HttpGet("OrdenenesEntregadasPendientes_Semanal")]
        public IActionResult OrdenenesEntregadasPendientes_Semanal()
        {
            var listado = _produccionServices.OrdenenesEntregadasPendientes_Semanal();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("PrendasPedidas")]
        public IActionResult PrendasPedidas(GraficasViewModel item)
        {
            var data = _mapper.Map<tbGraficas>(item);
            var listado = _produccionServices.PrendasPedidas(data);
            return Ok(listado);
        }

        [HttpGet("ClientesProductivos")]
        public IActionResult ClientesProductivos()
        {
            var listado = _produccionServices.ClientesProductivos();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }
        
        [HttpGet("ProductividadModulos")]
        public IActionResult ProductividadModulos()
        {
            var listado = _produccionServices.ProductividadModulos();
            listado.Data = _mapper.Map<IEnumerable<GraficasViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

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
    public class PODetallePorPedidoOrdenDetalleController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;
        public PODetallePorPedidoOrdenDetalleController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarPODetallePorPedidoOrdenDetalle();
            listado.Data = _mapper.Map<IEnumerable<PODetallePorPedidoOrdenDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(PODetallePorPedidoOrdenDetalleViewModel PODetallePorPedidoOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbPODetallePorPedidoOrdenDetalle>(PODetallePorPedidoOrdenDetalleViewModel);
            var respuesta = _produccionServices.InsertarPODetallePorPedidoOrdenDetalle(item);
            return Ok(respuesta);
        }


        [HttpPost("Eliminar")]
        public IActionResult Delete(PODetallePorPedidoOrdenDetalleViewModel PODetallePorPedidoOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbPODetallePorPedidoOrdenDetalle>(PODetallePorPedidoOrdenDetalleViewModel);
            var respuesta = _produccionServices.EliminarPODetallePorPedidoOrdenDetalle(item);
            return Ok(respuesta);
        }
    }
}

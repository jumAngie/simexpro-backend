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
    public class PedidosProduccionDetallesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public PedidosProduccionDetallesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(int ppro_Id)
        {
            var listado = _produccionServices.ListarPedidosProduccioDetalles(ppro_Id);
            listado.Data = _mapper.Map<IEnumerable<PedidosProduccionDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(PedidosProduccionDetalleViewModel pedidosProduccionDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccionDetalles>(pedidosProduccionDetalleViewModel);
            var respuesta = _produccionServices.InsertarPedidosProduccioDetalles(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(PedidosProduccionDetalleViewModel pedidosProduccionDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccionDetalles>(pedidosProduccionDetalleViewModel);
            var respuesta = _produccionServices.ActualizarPedidosProduccioDetalles(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PedidosProduccionDetalleViewModel pedidosProduccionDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccionDetalles>(pedidosProduccionDetalleViewModel);
            var respuesta = _produccionServices.EliminarPedidosProduccioDetalles(item);
            return Ok(respuesta);
        }

        [HttpGet("Filtrar")]
        public IActionResult Filter(int ppro_Id)
        {
            var listado = _produccionServices.FiltrarPedidosProduccioDetalles(ppro_Id);
            listado.Data = _mapper.Map<IEnumerable<PedidosProduccionDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

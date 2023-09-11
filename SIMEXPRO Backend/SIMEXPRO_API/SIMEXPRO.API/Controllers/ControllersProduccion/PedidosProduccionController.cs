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
    public class PedidosProduccionController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public PedidosProduccionController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarPedidosProduccion();
            listado.Data = _mapper.Map<IEnumerable<PedidosProduccionViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("Buscar")]
        public IActionResult Find(int id)
        {
            var listado = _produccionServices.FindPedidosProduccion(id);
            listado.Data = _mapper.Map<IEnumerable<PedidosProduccionViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(PedidosProduccionViewModel pedidosProduccionViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccion>(pedidosProduccionViewModel);
            var respuesta = _produccionServices.InsertarPedidosProduccion(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(PedidosProduccionViewModel pedidosProduccionViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccion>(pedidosProduccionViewModel);
            var respuesta = _produccionServices.ActualizarPedidosProduccion(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PedidosProduccionViewModel pedidosProduccionViewModel)
        {
            var item = _mapper.Map<tbPedidosProduccion>(pedidosProduccionViewModel);
            var respuesta = _produccionServices.EliminarPedidosProduccion(item);
            return Ok(respuesta);
        }

        [HttpPost("FinalizarPedidoProduccion")]
        public IActionResult FinalizarPedidoProduccion(PedidosProduccionViewModel pedidosProduccionViewModel)
        {
            var mapped = _mapper.Map<tbPedidosProduccion>(pedidosProduccionViewModel);
            var datos = _produccionServices.Finalizapedido(mapped);
            return Ok(datos);
        }
    }
}

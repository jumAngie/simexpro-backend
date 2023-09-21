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
    public class PedidosOrdenController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public PedidosOrdenController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarPedidosOrden();
            listado.Data = _mapper.Map<IEnumerable<PedidosOrdenViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("PedidoOrdenFind")]
        public IActionResult PedidoOrdenFind(string peor_Codigo)
        {
            var listado = _produccionServices.PedidoOrdenFind(peor_Codigo);
            listado.Data = _mapper.Map<IEnumerable<PedidosOrdenViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(PedidosOrdenViewModel pedidosOrdenViewModel)
        {
            var item = _mapper.Map<tbPedidosOrden>(pedidosOrdenViewModel);
            var respuesta = _produccionServices.InsertarPedidosOrden(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(PedidosOrdenViewModel pedidosOrdenViewModel)
        {
            var item = _mapper.Map<tbPedidosOrden>(pedidosOrdenViewModel);
            var respuesta = _produccionServices.ActualizarPedidosOrden(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PedidosOrdenViewModel pedidosOrdenViewModel)
        {
            var item = _mapper.Map<tbPedidosOrden>(pedidosOrdenViewModel);
            var respuesta = _produccionServices.EliminarPedidosOrden(item);
            return Ok(respuesta);
        }

        [HttpPost("FinalizarPedidoOrden")]
        public IActionResult FinalizarPedidoOrden(PedidosOrdenViewModel pedidosOrdenViewModel)
        {
            var mapped = _mapper.Map<tbPedidosOrden>(pedidosOrdenViewModel);
            var datos = _produccionServices.FinalizapedidoOrden(mapped);
            return Ok(datos);
        }
    }
}

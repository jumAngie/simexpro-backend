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
    }
}

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
    public class PedidosOrdenDetallesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public PedidosOrdenDetallesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(int pedi_Id)
        {
            var listado = _produccionServices.ListarPedidosOrdenDetalle(pedi_Id);
            listado.Data = _mapper.Map<IEnumerable<PedidosOrdenDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(PedidosOrdenDetalleViewModel pedidosOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosOrdenDetalle>(pedidosOrdenDetalleViewModel);
            var respuesta = _produccionServices.InsertarPedidosOrdenDetalle(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(PedidosOrdenDetalleViewModel pedidosOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosOrdenDetalle>(pedidosOrdenDetalleViewModel);
            var respuesta = _produccionServices.ActualizarPedidosOrdenDetalle(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PedidosOrdenDetalleViewModel pedidosOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbPedidosOrdenDetalle>(pedidosOrdenDetalleViewModel);
            var respuesta = _produccionServices.EliminarPedidosOrdenDetalle(item);
            return Ok(respuesta);
        }
    }
}

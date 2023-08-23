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
    public class ClientesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ClientesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarClientes();
            listado.Data = _mapper.Map<IEnumerable<ClientesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ClientesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbClientes>(clientesViewModel);
            var respuesta = _produccionServices.InsertarClientes(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ClientesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbClientes>(clientesViewModel);
            var respuesta = _produccionServices.ActualizarClientes(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ClientesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbClientes>(clientesViewModel);
            var respuesta = _produccionServices.EliminarClientes(item);
            return Ok(respuesta);
        }

        [HttpPost("Activar")]
        public IActionResult Activar(ClientesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbClientes>(clientesViewModel);
            var respuesta = _produccionServices.ActivarEstadoClientes(item);
            return Ok(respuesta);
        }

    }
}

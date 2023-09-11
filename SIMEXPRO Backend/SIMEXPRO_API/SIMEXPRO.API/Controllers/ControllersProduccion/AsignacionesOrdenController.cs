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
    public class AsignacionesOrdenController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public AsignacionesOrdenController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarAsignacionOrden();
            listado.Data = _mapper.Map<IEnumerable<AsignacionesOrdenViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("Find")]
        public IActionResult Find(string id)
        {
            var listado = _produccionServices.FindOrdenCompraDetalles(id);
            listado.Data = _mapper.Map<AsignacionesOrdenViewModel>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(AsignacionesOrdenViewModel asignacionesOrden)
        {
            var item = _mapper.Map<tbAsignacionesOrden>(asignacionesOrden);
            var respuesta = _produccionServices.InsertarAsignacionOrden(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(AsignacionesOrdenViewModel asignacionesOrden)
        {
            var item = _mapper.Map<tbAsignacionesOrden>(asignacionesOrden);
            var respuesta = _produccionServices.ActualizarAsignacionOrden(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(AsignacionesOrdenViewModel asignacionesOrden)
        {
            var item = _mapper.Map<tbAsignacionesOrden>(asignacionesOrden);
            var respuesta = _produccionServices.EliminarAsignacionOrden(item);
            return Ok(respuesta);
        }
    }
}

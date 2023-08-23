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
    public class ColoresController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ColoresController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarColores();
            listado.Data = _mapper.Map<IEnumerable<ColoresViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ColoresViewModel coloresViewModel)
        {
            var item = _mapper.Map<tbColores>(coloresViewModel);
            var respuesta = _produccionServices.InsertarColores(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ColoresViewModel coloresViewModel)
        {
            var item = _mapper.Map<tbColores>(coloresViewModel);
            var respuesta = _produccionServices.ActualizarColores(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(ColoresViewModel coloresViewModel)
        //{
        //    var item = _mapper.Map<tbColores>(coloresViewModel);
        //    var respuesta = _produccionServices.EliminarColores(item);
        //    return Ok(respuesta);
        //}
    }
}

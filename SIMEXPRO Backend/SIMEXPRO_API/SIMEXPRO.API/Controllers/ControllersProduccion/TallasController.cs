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
    public class TallasController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public TallasController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarTallas();
            listado.Data = _mapper.Map<IEnumerable<TallasViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(TallasViewModel TallasViewModel)
        {
            var item = _mapper.Map<tbTallas>(TallasViewModel);
            var respuesta = _produccionServices.InsertaTallas(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Editar(TallasViewModel TallasViewModel)
        {
            var item = _mapper.Map<tbTallas>(TallasViewModel);
            var respuesta = _produccionServices.ActualizarTallas(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Eliminar(TallasViewModel TallasViewModel)
        //{
        //    var item = _mapper.Map<tbTallas>(TallasViewModel);
        //    var respuesta = _produccionServices.EliminarTallas(item);
        //    return Ok(respuesta);
        //}

    }
}

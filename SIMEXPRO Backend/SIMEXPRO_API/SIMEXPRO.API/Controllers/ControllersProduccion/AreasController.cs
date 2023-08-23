using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
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
    public class AreasController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public AreasController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarAreas();
            listado.Data = _mapper.Map<IEnumerable<AreasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(AreasViewModel areasViewModel)
        {
            var item = _mapper.Map<tbArea>(areasViewModel);
            var respuesta = _produccionServices.InsertarAreas(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(AreasViewModel areasViewModel)
        {
            var item = _mapper.Map<tbArea>(areasViewModel);
            var respuesta = _produccionServices.ActualizarAreas(item);
            return Ok(respuesta);
        }
        [HttpPost("Eliminar")]
        public IActionResult Delete(AreasViewModel areasViewModel)
        {
            var item = _mapper.Map<tbArea>(areasViewModel);
            var respuesta = _produccionServices.EliminarAreas(item);
            return Ok(respuesta);
        }


    }
}

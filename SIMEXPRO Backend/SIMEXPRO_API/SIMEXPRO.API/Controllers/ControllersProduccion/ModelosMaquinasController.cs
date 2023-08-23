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
    public class ModelosMaquinasController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ModelosMaquinasController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarModelosMaquina();
            listado.Data = _mapper.Map<IEnumerable<ModelosMaquinaViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(ModelosMaquinaViewModel modelosMaquinaViewModel)
        {
            var item = _mapper.Map<tbModelosMaquina>(modelosMaquinaViewModel);
            var respuesta = _produccionServices.InsertarModelosMaquina(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(ModelosMaquinaViewModel modelosMaquinaViewModel)
        {
            var item = _mapper.Map<tbModelosMaquina>(modelosMaquinaViewModel);
            var respuesta = _produccionServices.ActualizarModelosMaquina(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ModelosMaquinaViewModel modelosMaquinaViewModel)
        {
            var item = _mapper.Map<tbModelosMaquina>(modelosMaquinaViewModel);
            var respuesta = _produccionServices.EliminarModelosMaquina(item);
            return Ok(respuesta);
        }

    }
}

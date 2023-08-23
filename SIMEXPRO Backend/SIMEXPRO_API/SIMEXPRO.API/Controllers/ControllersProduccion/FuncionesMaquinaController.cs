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
    public class FuncionesMaquinaController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public FuncionesMaquinaController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarFuncionesMaquina();
            listado.Data = _mapper.Map<IEnumerable<FuncionesMaquinaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(FuncionesMaquinaViewModel funcionesMaquinaViewModel)
        {
            var item = _mapper.Map<tbFuncionesMaquina>(funcionesMaquinaViewModel);
            var respuesta = _produccionServices.InsertarFuncionesMaquina(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(FuncionesMaquinaViewModel funcionesMaquinaViewModel)
        {
            var item = _mapper.Map<tbFuncionesMaquina>(funcionesMaquinaViewModel);
            var respuesta = _produccionServices.ActualizarFuncionesMaquina(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(FuncionesMaquinaViewModel funcionesMaquinaViewModel)
        {
            var item = _mapper.Map<tbFuncionesMaquina>(funcionesMaquinaViewModel);
            var respuesta = _produccionServices.EliminarFuncionesMaquina(item);
            return Ok(respuesta);
        }


    }
}

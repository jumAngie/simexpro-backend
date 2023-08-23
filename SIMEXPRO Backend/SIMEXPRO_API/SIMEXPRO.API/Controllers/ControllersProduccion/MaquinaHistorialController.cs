using AutoMapper;
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
    public class MaquinaHistorialController : Controller
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public MaquinaHistorialController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarMaquinaHistorial();
            listado.Data = _mapper.Map<IEnumerable<MaquinaHistorialViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(MaquinaHistorialViewModel maquinasHistorialViewModel)
        {
            var item = _mapper.Map<tbMaquinaHistorial>(maquinasHistorialViewModel);
            var respuesta = _produccionServices.InsertarMaquinaHistorial(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(MaquinaHistorialViewModel maquinasHistorialViewModel)
        {
            var item = _mapper.Map<tbMaquinaHistorial>(maquinasHistorialViewModel);
            var respuesta = _produccionServices.ActualizarMaquinaHistorial(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(MaquinaHistorialViewModel maquinasHistorialViewModel)
        {
            var item = _mapper.Map<tbMaquinaHistorial>(maquinasHistorialViewModel);
            var respuesta = _produccionServices.EliminarMaquinaHistorial(item);
            return Ok(respuesta);
        }
    }
}

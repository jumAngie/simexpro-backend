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
    public class ModulosController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ModulosController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarModulos();
            listado.Data = _mapper.Map<IEnumerable<ModulosViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(ModulosViewModel modulosViewModel)
        {
            var item = _mapper.Map<tbModulos>(modulosViewModel);
            var respuesta = _produccionServices.InsertarModulos(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ModulosViewModel modulosViewModel)
        {
            var item = _mapper.Map<tbModulos>(modulosViewModel);
            var respuesta = _produccionServices.ActualizarModulos(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ModulosViewModel modulosViewModel)
        {
            var item = _mapper.Map<tbModulos>(modulosViewModel);
            var respuesta = _produccionServices.EliminarModulos(item);
            return Ok(respuesta);
        }
    }
}

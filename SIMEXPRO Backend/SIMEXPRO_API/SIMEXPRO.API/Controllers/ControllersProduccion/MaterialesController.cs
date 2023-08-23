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
    public class MaterialesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public MaterialesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarMateriales();
            listado.Data = _mapper.Map<IEnumerable<MaterialesViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(MaterialesViewModel materialesViewModel)
        {
            var item = _mapper.Map<tbMateriales>(materialesViewModel);
            var respuesta = _produccionServices.InsertarMateriales(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(MaterialesViewModel materialesViewModel)
        {
            var item = _mapper.Map<tbMateriales>(materialesViewModel);
            var respuesta = _produccionServices.ActualizarMateriales(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(MaterialesViewModel materialesViewModel)
        {
            var item = _mapper.Map<tbMateriales>(materialesViewModel);
            var respuesta = _produccionServices.EliminarMateriales(item);
            return Ok(respuesta);
        }
    }
}

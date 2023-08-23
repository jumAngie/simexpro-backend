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
    public class CategoriaController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public CategoriaController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarCategorias();
            listado.Data = _mapper.Map<IEnumerable<CategoriaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(CategoriaViewModel categoriaViewModel)
        {
            var item = _mapper.Map<tbCategoria>(categoriaViewModel);
            var respuesta = _produccionServices.InsertarCategorias(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(CategoriaViewModel categoriaViewModel)
        {
            var item = _mapper.Map<tbCategoria>(categoriaViewModel);
            var respuesta = _produccionServices.ActualizarCategorias(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(CategoriaViewModel categoriaViewModel)
        {
            var item = _mapper.Map<tbCategoria>(categoriaViewModel);
            var respuesta = _produccionServices.EliminarCategorias(item);
            return Ok(respuesta);
        }
    }
}

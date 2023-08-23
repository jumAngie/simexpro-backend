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
    public class SubCategoriaController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public SubCategoriaController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarSubCategorias();
         
            listado.Data = _mapper.Map<IEnumerable<SubCategoriaViewModel>>(listado.Data);
            return Ok(listado);
        }
        
        [HttpGet("ListarByIdCategoria")]
        public IActionResult ListByIdCategoria(int cate_Id)
        {
            var listado = _produccionServices.ListarSubCategoriasByIdCategoria(cate_Id);

            listado.Data = _mapper.Map<IEnumerable<SubCategoriaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(SubCategoriaViewModel SubCategoriaViewModel)
        {
            var item = _mapper.Map<tbSubcategoria>(SubCategoriaViewModel);
            var respuesta = _produccionServices.InsertarSubCategorias(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(SubCategoriaViewModel SubCategoriaViewModel)
        {
            var item = _mapper.Map<tbSubcategoria>(SubCategoriaViewModel);
            var respuesta = _produccionServices.ActualizarSubCategorias(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(SubCategoriaViewModel SubCategoriaViewModel)
        {
            var item = _mapper.Map<tbSubcategoria>(SubCategoriaViewModel);
            var respuesta = _produccionServices.EliminarSubCategorias(item);
            return Ok(respuesta);
        }



    }
}

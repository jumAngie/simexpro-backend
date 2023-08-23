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
    public class MaterialesBrindarController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public MaterialesBrindarController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarMaterialesBrindados();
            listado.Data = _mapper.Map<IEnumerable<MaterialesBrindarViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("ListarFiltrado")]
        public IActionResult Index(int code_Id)
        {
            var listado = _produccionServices.ListarMaterialesBrindadosFiltrado(code_Id);
            listado.Data = _mapper.Map<IEnumerable<MaterialesBrindarViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(MaterialesBrindarViewModel materialesBrindarViewModel)
        {
            var item = _mapper.Map<tbMaterialesBrindar>(materialesBrindarViewModel);
            var respuesta = _produccionServices.InsertarMaterialesBrindados(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(MaterialesBrindarViewModel materialesBrindarViewModel)
        {
            var item = _mapper.Map<tbMaterialesBrindar>(materialesBrindarViewModel);
            var respuesta = _produccionServices.ActualizarMaterialesBrindados(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(MaterialesBrindarViewModel materialesBrindarViewModel)
        {
            var item = _mapper.Map<tbMaterialesBrindar>(materialesBrindarViewModel);
            var respuesta = _produccionServices.EliminarMaterialesBrindados(item);
            return Ok(respuesta);
        }

    }
}

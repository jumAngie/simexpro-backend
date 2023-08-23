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
    public class RevisionDeCalidadController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public RevisionDeCalidadController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarRevisionDeCalidad();
            listado.Data = _mapper.Map<IEnumerable<RevisionDeCalidadViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(RevisionDeCalidadViewModel RevisionDeCalidadViewModel)
        {
            var item = _mapper.Map<tbRevisionDeCalidad>(RevisionDeCalidadViewModel);
            var respuesta = _produccionServices.InsertarRevisionDeCalidad(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(RevisionDeCalidadViewModel RevisionDeCalidadViewModel)
        {
            var item = _mapper.Map<tbRevisionDeCalidad>(RevisionDeCalidadViewModel);
            var respuesta = _produccionServices.ActualizarRevisionDeCalidad(item);
            return Ok(respuesta);
        }


    }
}

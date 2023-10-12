using AutoMapper;
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
    public class ImpuestoProdController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ImpuestoProdController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarImpuestoPro();
            listado.Data = _mapper.Map<IEnumerable<ImpuestoProdViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ImpuestoProdViewModel impuestoProdViewModel)
        {
            var item = _mapper.Map<tbImpuestosProd>(impuestoProdViewModel);
            var respuesta = _produccionServices.ActualizarImpuestoProd(item);
            return Ok(respuesta);
        }
    }
}

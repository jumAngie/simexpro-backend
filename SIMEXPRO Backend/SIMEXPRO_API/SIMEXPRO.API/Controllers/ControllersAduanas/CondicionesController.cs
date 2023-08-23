using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionesController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public CondicionesController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarCondiciones();
            listado.Data = _mapper.Map<IEnumerable<CondicionesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(CondicionesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbCondiciones>(clientesViewModel);
            var respuesta = _aduanaServices.InsertarCondiciones(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(CondicionesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbCondiciones>(clientesViewModel);
            var respuesta = _aduanaServices.ActualizarCondiciones(item);
            return Ok(respuesta);
        }

    }
}

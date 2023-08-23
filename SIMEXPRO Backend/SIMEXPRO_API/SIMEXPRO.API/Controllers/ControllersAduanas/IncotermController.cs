using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.Entities.Entities;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncotermController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public IncotermController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarIncoterm();
            listado.Data = _mapper.Map<IEnumerable<IncotermViewModel>>(listado.Data);
            return Ok(listado);
        }
        [HttpPost("Insertar")]
        public IActionResult Insert(IncotermViewModel incotermViewModel)
        {
            var item = _mapper.Map<tbIncoterm>(incotermViewModel);
            var respuesta = _aduanaServices.InsertarIncoterm(item);
            return Ok(respuesta);
        }
        [HttpPost("Editar")]
        public IActionResult Update(IncotermViewModel incotermViewModel)
        {
            var item = _mapper.Map<tbIncoterm>(incotermViewModel);
            var respuesta = _aduanaServices.ActualizarIncoterm(item);
            return Ok(respuesta);
        }

    }
}

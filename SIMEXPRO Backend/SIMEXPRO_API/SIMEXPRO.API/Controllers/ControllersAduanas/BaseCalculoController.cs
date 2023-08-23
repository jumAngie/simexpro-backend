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
    public class BaseCalculoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public BaseCalculoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarBaseCalculos();
            var mapped = _mapper.Map<IEnumerable<ArancelesViewModel>>(listado);
            return Ok(mapped);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(ArancelesViewModel baseCalculo)
        {
            var mapped = _mapper.Map<tbBaseCalculos>(baseCalculo);
            var datos = _aduanaServices.InsertarBaseCalculos(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(ArancelesViewModel baseCalculo)
        {
            var mapped = _mapper.Map<tbBaseCalculos>(baseCalculo);
            var datos = _aduanaServices.ActualizarBaseCalculos(mapped);
            return Ok(datos);
        }


    }
}

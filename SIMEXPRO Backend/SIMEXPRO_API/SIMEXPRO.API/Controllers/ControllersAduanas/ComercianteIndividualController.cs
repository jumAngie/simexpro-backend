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
    public class ComercianteIndividualController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ComercianteIndividualController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarComercianteIndividual();
            listado.Data = _mapper.Map<IEnumerable<ComercianteIndividual>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(ComercianteIndividual comercianteIndividual)
        {
            var mapped = _mapper.Map<tbComercianteIndividual>(comercianteIndividual);
            var datos = _aduanaServices.InsertarComercianteIndividual(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(ComercianteIndividual comercianteIndividual)
        {
            var mapped = _mapper.Map<tbComercianteIndividual>(comercianteIndividual);
            var datos = _aduanaServices.ActualizarComercianteIndividual(mapped);
            return Ok(datos);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Eliminar(ComercianteIndividual comercianteIndividual)
        //{
        //    var mapped = _mapper.Map<tbComercianteIndividual>(comercianteIndividual);
        //    var datos = _aduanaServices.EliminarComercianteIndividual(mapped);
        //    return Ok(datos);
        //}
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
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
    public class PersonasController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public PersonasController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarPersonas();
            listado.Data = _mapper.Map<IEnumerable<PersonasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(PersonasViewModel personasViewModel)
        {
            var item = _mapper.Map<tbPersonas>(personasViewModel);
            var respuesta = _aduanaServices.InsertarPersonas(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(PersonasViewModel personasViewModel)
        {
            var item = _mapper.Map<tbPersonas>(personasViewModel);
            var respuesta = _aduanaServices.ActualizarPersonas(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PersonasViewModel personasViewModel)
        {
            var item = _mapper.Map<tbPersonas>(personasViewModel);
            var respuesta = _aduanaServices.EliminarPersonas(item);
            return Ok(respuesta);
        }
    }
}

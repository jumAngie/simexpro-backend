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
    public class PersonaJuridicaController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public PersonaJuridicaController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarPersonaJuridica();

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(PersonaJuridicaViewModel concepto)
        {
            var item = _mapper.Map<tbPersonaJuridica>(concepto);

            var respuesta = _aduanaServices.InsertarPersonaJuridica(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        [HttpPost("Editar")]
        public IActionResult Update(PersonaJuridicaViewModel concepto)
        {
            var item = _mapper.Map<tbPersonaJuridica>(concepto);

            var respuesta = _aduanaServices.ActualizarPersonaJuridica(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(PersonaJuridicaViewModel concepto)
        {
            var item = _mapper.Map<tbPersonaJuridica>(concepto);

            var respuesta = _aduanaServices.EliminarPersonaJuridica(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }
    }
}

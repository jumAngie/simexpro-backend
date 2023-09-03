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
            var listado = _aduanaServices.ListarPersonaJuridica();
            listado.Data = _mapper.Map<IEnumerable<PersonaJuridicaViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(PersonaJuridicaViewModel personaJuridica)
        {
            var mapped = _mapper.Map<tbPersonaJuridica>(personaJuridica);
            var datos = _aduanaServices.InsertarPersonaJuridica(mapped);
            return Ok(datos);
        }

        [HttpPost("InsertarTap2")]
        public IActionResult InsertarTap2(PersonaJuridicaViewModel personaJuridica)
        {
            var mapped = _mapper.Map<tbPersonaJuridica>(personaJuridica);
            var datos = _aduanaServices.InsertarPersonaJuridicaTap2(mapped);
            return Ok(datos);
        }

        [HttpPost("InsertarTap3")]
        public IActionResult InsertarTap3(PersonaJuridicaViewModel personaJuridica)
        {
            var mapped = _mapper.Map<tbPersonaJuridica>(personaJuridica);
            var datos = _aduanaServices.InsertarPersonaJuridicaTap3(mapped);
            return Ok(datos);
        }

        [HttpPost("InsertarTap4")]
        public IActionResult InsertarTap4(PersonaJuridicaViewModel personaJuridica)
        {
            var mapped = _mapper.Map<tbPersonaJuridica>(personaJuridica);
            var datos = _aduanaServices.InsertarPersonaJuridicaTap4(mapped);
            return Ok(datos);
        }

        [HttpPost("InsertarTap5")]
        public IActionResult InsertarTap5(PersonaJuridicaViewModel personaJuridica)
        {
            var mapped = _mapper.Map<tbPersonaJuridica>(personaJuridica);
            var datos = _aduanaServices.InsertarPersonaJuridicaTap5(mapped);
            return Ok(datos);
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

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
    public class ConceptoPagoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ConceptoPagoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarConceptoPago();

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
        public IActionResult Insert(ConceptoPagoViewModel concepto)
        {
            var item = _mapper.Map<tbConceptoPago>(concepto);

            var respuesta = _aduanaServices.InsertarConceptoPago(item);

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
        public IActionResult Update(ConceptoPagoViewModel concepto)
        {
            var item = _mapper.Map<tbConceptoPago>(concepto);

            var respuesta = _aduanaServices.ActualizarConceptoPago(item);

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
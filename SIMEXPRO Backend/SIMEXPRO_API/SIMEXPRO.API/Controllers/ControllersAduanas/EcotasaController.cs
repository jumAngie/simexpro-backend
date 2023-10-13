using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    public class EcotasaController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public EcotasaController(AduanaServices aduanaServices, IMapper mapper)
        {
            _aduanaServices = aduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarEcotasa();
            listado.Data = _mapper.Map<IEnumerable<EcotasaViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insertar(EcotasaViewModel aduanas)
        {
            var mapped = _mapper.Map<tbEcotasa>(aduanas);
            var datos = _aduanaServices.InsertarEcotasa(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(EcotasaViewModel aduanas)
        {
            var mapped = _mapper.Map<tbEcotasa>(aduanas);
            var datos = _aduanaServices.ActualizarEcotasa(mapped);
            return Ok(datos);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(EcotasaViewModel aduanas)
        {
            var mapped = _mapper.Map<tbEcotasa>(aduanas);
            var datos = _aduanaServices.EliminarEcotasa(mapped);
            return Ok(datos);
        }
    }
}

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
    public class ArancelesController : ControllerBase
    {

        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ArancelesController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarAranceles();
            listado.Data = _mapper.Map<IEnumerable<ArancelesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(AracelesViewModel aranceles)
        {
            var mapped = _mapper.Map<tbAranceles>(aranceles);
            var datos = _aduanaServices.InsertarAranceles(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(AracelesViewModel aranceles)
        {
            var mapped = _mapper.Map<tbAranceles>(aranceles);
            var datos = _aduanaServices.ActualizarAranceles(mapped);
            return Ok(datos);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Eliminar(ArancelesViewModel aranceles)
        //{
        //    var mapped = _mapper.Map<tbAranceles>(aranceles);
        //    var datos = _aduanaServices.EliminarAranceles(mapped);
        //    return Ok(datos);
        //}

    }
}

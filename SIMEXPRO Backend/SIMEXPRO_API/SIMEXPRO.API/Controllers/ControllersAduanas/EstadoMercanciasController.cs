using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.API.Models.ModelsProduccion;
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
    public class EstadoMercanciasController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public EstadoMercanciasController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarEstadoMercancias();
            listado.Data = _mapper.Map<IEnumerable<EstadoMercanciasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insertar(EstadoMercanciasViewModel EstadoMercanciasViewModel)
        {
            var item = _mapper.Map<tbEstadoMercancias>(EstadoMercanciasViewModel);
            var respuesta = _aduanaServices.InsertarEstadoMercancias(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(EstadoMercanciasViewModel EstadoMercanciasViewModel)
        {
            var item = _mapper.Map<tbEstadoMercancias>(EstadoMercanciasViewModel);
            var respuesta = _aduanaServices.ActualizarEstadoMercancias(item);
            return Ok(respuesta);
        }


        //[HttpPost("Eliminar")]
        //public IActionResult Eliminar(EstadoMercanciasViewModel EstadoMercanciasViewModel)
        //{
        //    var item = _mapper.Map<tbEstadoMercancias>(EstadoMercanciasViewModel);
        //    var respuesta = _aduanaServices.EliminarEstadoMercancias(item);
        //    return Ok(respuesta);
        //}

    }
}

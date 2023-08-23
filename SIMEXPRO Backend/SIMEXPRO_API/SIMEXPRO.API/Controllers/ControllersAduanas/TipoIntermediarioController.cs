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
    public class TipoIntermediarioController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public TipoIntermediarioController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarTipoIntermediario();
            listado.Data = _mapper.Map<IEnumerable<TipoIntermediarioViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(TipoIntermediarioViewModel tipoIntermediarioViewModel)
        {
            var item = _mapper.Map<tbTipoIntermediario>(tipoIntermediarioViewModel);
            var respuesta = _aduanaServices.InsertarTipoIntermediario(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(TipoIntermediarioViewModel tipoIntermediarioViewModel)
        {
            var item = _mapper.Map<tbTipoIntermediario>(tipoIntermediarioViewModel);
            var respuesta = _aduanaServices.ActualizarTipoIntermediario(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(TipoIntermediarioViewModel tipoIntermediarioViewModel)
        //{
        //    var item = _mapper.Map<tbTipoIntermediario>(tipoIntermediarioViewModel);
        //    var respuesta = _aduanaServices.EliminarTipoIntermediario(item);
        //    return Ok(respuesta);
        //}
    }
}

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
    public class TiposIdentificacionController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public TiposIdentificacionController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarTiposIdentificacion();
            listado.Data = _mapper.Map<IEnumerable<TiposIdentificacionViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(TiposIdentificacionViewModel tiposIdentificacionViewModel)
        {
            var item = _mapper.Map<tbTiposIdentificacion>(tiposIdentificacionViewModel);
            var respuesta = _aduanaServices.InsertarTiposIdentificacion(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(TiposIdentificacionViewModel tiposIdentificacionViewModel)
        {
            var item = _mapper.Map<tbTiposIdentificacion>(tiposIdentificacionViewModel);
            var respuesta = _aduanaServices.ActualizarTiposIdentificacion(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(TiposIdentificacionViewModel tiposIdentificacionViewModel)
        //{
        //    var item = _mapper.Map<tbTiposIdentificacion>(tiposIdentificacionViewModel);
        //    var respuesta = _aduanaServices.EliminarTiposIdentificacion(item);
        //    return Ok(respuesta);
        //}
    }
}

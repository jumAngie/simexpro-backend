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
    public class ModoTransporteController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ModoTransporteController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarModoTransporte();
            respuesta.Data = _mapper.Map<IEnumerable<ModoTransporteViewModel>>(respuesta.Data);
            return Ok(respuesta);

        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ModoTransporteViewModel concepto)
        {
            var item = _mapper.Map<tbModoTransporte>(concepto);

            var respuesta = _aduanaServices.InsertarModoTransporte(item);

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
        public IActionResult Update(ModoTransporteViewModel concepto)
        {
            var item = _mapper.Map<tbModoTransporte>(concepto);

            var respuesta = _aduanaServices.ActualizarModoTransporte(item);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(ModoTransporteViewModel concepto)
        //{
        //    var item = _mapper.Map<tbModoTransporte>(concepto);

        //    var respuesta = _aduanaServices.EliminarModoTransporte(item);

        //    if (respuesta.Code == 200)
        //    {
        //        return Ok(respuesta);
        //    }
        //    else
        //    {
        //        return BadRequest(respuesta);
        //    }
        //}
    }
}

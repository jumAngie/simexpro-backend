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
    public class MarcasController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public MarcasController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var respuesta = _aduanaServices.ListarMarcas();
            respuesta.Data = _mapper.Map<IEnumerable<MarcasViewModel>>(respuesta.Data);
            return Ok(respuesta);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(MarcasViewModel concepto)
        {
            var item = _mapper.Map<tbMarcas>(concepto);

            var respuesta = _aduanaServices.InsertarMarcas(item);

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
        public IActionResult Update(MarcasViewModel concepto)
        {
            var item = _mapper.Map<tbMarcas>(concepto);

            var respuesta = _aduanaServices.ActualizarMarcas(item);

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
        public IActionResult Delete(MarcasViewModel concepto)
        {
            var item = _mapper.Map<tbMarcas>(concepto);

            var respuesta = _aduanaServices.EliminarMarcas(item);

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

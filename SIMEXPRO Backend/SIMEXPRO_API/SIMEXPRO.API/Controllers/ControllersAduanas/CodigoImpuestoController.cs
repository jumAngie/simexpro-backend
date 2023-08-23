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
    public class CodigoImpuestoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public CodigoImpuestoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarCodigoImpuesto();
            listado.Data = _mapper.Map<IEnumerable<CodigoImpuestoViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(CodigoImpuestoViewModel codigoImpuesto)
        {
            var mapped = _mapper.Map<tbCodigoImpuesto>(codigoImpuesto);
            var datos = _aduanaServices.InsertarCodigoImpuesto(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(CodigoImpuestoViewModel codigoImpuesto)
        {
            var mapped = _mapper.Map<tbCodigoImpuesto>(codigoImpuesto);
            var datos = _aduanaServices.ActualizarCodigoImpuesto(mapped);
            return Ok(datos);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(CodigoImpuestoViewModel codigoImpuesto)
        {
            var mapped = _mapper.Map<tbCodigoImpuesto>(codigoImpuesto);
            var datos = _aduanaServices.EliminarCodigoImpuesto(mapped);
            return Ok(datos);
        }
    }
}

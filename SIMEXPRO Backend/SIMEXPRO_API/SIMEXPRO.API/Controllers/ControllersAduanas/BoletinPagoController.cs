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
    public class BoletinPagoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public BoletinPagoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarBoletinPago();
            listado.Data = _mapper.Map<IEnumerable<BoletinPagoViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(BoletinPagoViewModel boletinPago)
        {
            var mapped = _mapper.Map<tbBoletinPago>(boletinPago);
            var datos = _aduanaServices.InsertarBoletinPago(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(BoletinPagoViewModel boletinPago)
        {
            var mapped = _mapper.Map<tbBoletinPago>(boletinPago);
            var datos = _aduanaServices.ActualizarBoletinPago(mapped);
            return Ok(datos);
        }


    }
}

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
    public class BoletinPagoDetallesController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public BoletinPagoDetallesController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("ListarByIdBoletin")]
        public IActionResult ListadoByIdBoletin(int boen_Id)
        {
            var listado = _aduanaServices.ListarDetallesBoletinPagoByIdBoletin(boen_Id);
            listado.Data = _mapper.Map<IEnumerable<BoletinPagoDetallesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(BoletinPagoDetallesViewModel item)
        {
            var result = _aduanaServices.InsertarBoletinPagoDetalles(_mapper.Map<tbBoletinPagoDetalles>(item));
            return Ok(result);
        }

        [HttpPost("Editar")]
        public IActionResult Update(BoletinPagoDetallesViewModel item)
        {
            var result = _aduanaServices.ActualizarBoletinPagoDetalles(_mapper.Map<tbBoletinPagoDetalles>(item));
            return Ok(result);
        }
    }
}

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
    public class EstadoBoletinController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public EstadoBoletinController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult List()
        {
            var list = _aduanaServices.ListarEstadoBoletin();

            list.Data = _mapper.Map<IEnumerable<EstadoBoletinViewModel>>(list.Data);

            return Ok(list);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(EstadoBoletinViewModel item)
        {
            var result = _aduanaServices.InsertarEstadoBoletin(_mapper.Map<tbEstadoBoletin>(item));

            return Ok(result);
        }

        [HttpPost("Editar")]
        public IActionResult Update(EstadoBoletinViewModel item)
        {
            var result = _aduanaServices.ActualizarEstadoBoletin(_mapper.Map<tbEstadoBoletin>(item));

            return Ok(result);
        }
    }
}

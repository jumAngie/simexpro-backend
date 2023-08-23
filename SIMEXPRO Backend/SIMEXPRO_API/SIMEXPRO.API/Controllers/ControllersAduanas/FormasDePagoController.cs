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
    public class FormasDePagoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public FormasDePagoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult List()
        {
            var list = _aduanaServices.ListarFormasdePago();
            list.Data = _mapper.Map<IEnumerable<FormasDePagoViewModel>>(list.Data);
            return Ok(list);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(FormasDePagoViewModel item)
        {
            var result = _aduanaServices.InsertarFormasdePago(_mapper.Map<tbFormasdePago>(item));
            return Ok(result);
        }

        [HttpPost("Editar")]
        public IActionResult Update(FormasDePagoViewModel item)
        {
            var result = _aduanaServices.ActualizarFormasdePago(_mapper.Map<tbFormasdePago>(item));

            return Ok(result);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(FormasDePagoViewModel item)
        //{
        //    var result = _aduanaServices.EliminarFormasdePago(_mapper.Map<tbFormasdePago>(item));

        //    return Ok(result);
        //}
    }
}

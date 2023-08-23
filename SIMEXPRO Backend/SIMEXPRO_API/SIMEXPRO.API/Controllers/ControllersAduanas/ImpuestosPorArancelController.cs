using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMEXPRO.API.Models.ModelsAduana;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpuestosPorArancelController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;
        private object _aduanasServices;

        public ImpuestosPorArancelController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        //[HttpGet("Listar")]
        //public IActionResult Index()
        //{
        //    var listado = _aduanasServices();
        //    listado.Data = _mapper.Map<IEnumerable<ImpuestosPorAracelViewModel>>(listado.Data);
        //    return Ok(listado);
        //}


        //[HttpPost("Insert")]
        //public IActionResult Insert(ColoniasViewModel coloniasViewModel)
        //{
        //    var item = _mapper.Map<tbColonias>(coloniasViewModel);
        //    var respuesta = _generalesServices.InsertarColonias(item);
        //    return Ok(respuesta);
        //}


        //[HttpPost("Update")]
        //public IActionResult Update(ColoniasViewModel coloniasViewModel)
        //{
        //    var item = _mapper.Map<tbColonias>(coloniasViewModel);
        //    var respuesta = _generalesServices.ActualizarColonias(item);
        //    return Ok(respuesta);
        //}

        //[HttpPost("Delete")]
        //public IActionResult Delete(ColoniasViewModel coloniasViewModel)
        //{
        //    var item = _mapper.Map<tbColonias>(coloniasViewModel);
        //    var respuesta = _generalesServices.EliminarColonias(item);
        //    return Ok(respuesta);
        //}
    }
}

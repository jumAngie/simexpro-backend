using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
using SIMEXPRO.BussinessLogic.Services.GeneralServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersGenerales
{

    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public MonedaController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
      
        
        [HttpGet("Listar")]
        public IActionResult Index(bool? mone_EsAduana)
        {
            var listado = _generalesServices.ListarMonedas(mone_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<MonedasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(MonedasViewModel monedasViewModel)
        {
            var item = _mapper.Map<tbMonedas>(monedasViewModel);
            var respuesta = _generalesServices.InsertarMonedas(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(MonedasViewModel monedasViewModel)
        {
            var item = _mapper.Map<tbMonedas>(monedasViewModel);
            var respuesta = _generalesServices.ActualizarMonedas(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(MonedasViewModel monedasViewModel)
        //{
        //    var item = _mapper.Map<tbMonedas>(monedasViewModel);
        //    var respuesta = _generalesServices.EliminarMonedas(item);
        //    return Ok(respuesta);
        //}
    }
}

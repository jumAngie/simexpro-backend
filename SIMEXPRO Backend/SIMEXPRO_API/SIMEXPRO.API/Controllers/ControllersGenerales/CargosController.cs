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
    public class CargosController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public CargosController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(bool? carg_EsAduana)
        {
            var listado = _generalesServices.ListarCargos(carg_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<CargosViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(CargosViewModel cargosViewModel)
        {
            var item = _mapper.Map<tbCargos>(cargosViewModel);
            var respuesta = _generalesServices.InsertarCargos(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(CargosViewModel cargosViewModel)
        {
            var item = _mapper.Map<tbCargos>(cargosViewModel);
            var respuesta = _generalesServices.ActualizarCargos(item);
            return Ok(respuesta);
        }


    }
}

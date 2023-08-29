using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
using SIMEXPRO.BussinessLogic.Services;
using SIMEXPRO.BussinessLogic.Services.GeneralServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosCivilesController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public EstadosCivilesController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult ListarEstadosCiviles(bool? escv_EsAduana)
        {
            var list = _generalesServices.ListarEstadosCiviles(escv_EsAduana);
            list.Data = _mapper.Map<IEnumerable<EstadosCivilesViewModel>>(list.Data);
            return Ok(list);
        }

        [HttpPost("Insertar")]
        public IActionResult InsertarEstadoCivil(EstadosCivilesViewModel EstadosCivilesViewModel)
        {
            var item = _mapper.Map<tbEstadosCiviles>(EstadosCivilesViewModel);
            var response = _generalesServices.InsertarEstadosCiviles(item);
            return Ok(response);
        }

        [HttpPost("Editar")]
        public IActionResult ActualizarEstadoCivil(EstadosCivilesViewModel estadosCivilesViewModel)
        {
            var item = _mapper.Map<tbEstadosCiviles>(estadosCivilesViewModel);
            var response = _generalesServices.ActualizarEstadosCiviles(item);
            return Ok(response);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(EstadosCivilesViewModel estadosCivilesViewModel)
        {
            var item = _mapper.Map<tbEstadosCiviles>(estadosCivilesViewModel);
            var respuesta = _generalesServices.EliminarEstadosCiviles(item);
            return Ok(respuesta);
        }
    }
}

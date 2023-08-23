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
    public class PaisesController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public PaisesController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index(bool? pais_EsAduana)
        {
            var listado = _generalesServices.ListarPaises(pais_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<PaisesViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(PaisesViewModel paisesViewModel)
        {
            var item = _mapper.Map<tbPaises>(paisesViewModel);
            var respuesta = _generalesServices.InsertarPaises(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(PaisesViewModel paisesViewModel)
        {
            var item = _mapper.Map<tbPaises>(paisesViewModel);
            var respuesta = _generalesServices.ActualizarPaises(item);
            return Ok(respuesta);
        }
        //[HttpPost("Delete")]
        //public IActionResult Delete(PaisesViewModel paisesViewModel)
        //{
        //    var item = _mapper.Map<tbPaises>(paisesViewModel);
        //    var respuesta = _generalesServices.EliminarPaises(item);
        //    return Ok(respuesta);
        //}
    }
}

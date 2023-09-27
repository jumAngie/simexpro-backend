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
    public class ProvinciasController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public ProvinciasController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(bool? pvin_EsAduana)
        {
            var listado = _generalesServices.ListarProvincias(pvin_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<ProvinciasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(ProvinciasViewModel provinciasViewModel)
        {
            var item = _mapper.Map<tbProvincias>(provinciasViewModel);
            var respuesta = _generalesServices.InsertarProvincias(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ProvinciasViewModel provinciasViewModel)
        {
            var item = _mapper.Map<tbProvincias>(provinciasViewModel);
            var respuesta = _generalesServices.ActualizarProvincias(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(ProvinciasViewModel provinciasViewModel)
        //{
        //    var item = _mapper.Map<tbProvincias>(provinciasViewModel);
        //    var respuesta = _generalesServices.EliminarProvincias(item);
        //    return Ok(respuesta);
        //}

        [HttpGet("ProvinciasFiltradaPorPais")]
        public IActionResult ProvinciasPorPaises(int pais_Id )
        {
          
            var respuesta = _generalesServices.ProvinciasPorPaises(pais_Id);
            respuesta.Data = _mapper.Map<IEnumerable<ProvinciasViewModel>>(respuesta.Data);
            return Ok(respuesta);
        }


        [HttpGet("ProvinciasFiltradaPorPaisYesAduana")]
        public IActionResult ProvinciasPorPaisesYaduana(int pais_Id, bool pvin_EsAduana)
        {

            var respuesta = _generalesServices.ProvinciasPorPaisesYesAduana(pais_Id, pvin_EsAduana);
            respuesta.Data = _mapper.Map<IEnumerable<ProvinciasViewModel>>(respuesta.Data);
            return Ok(respuesta);
        }


    }
}

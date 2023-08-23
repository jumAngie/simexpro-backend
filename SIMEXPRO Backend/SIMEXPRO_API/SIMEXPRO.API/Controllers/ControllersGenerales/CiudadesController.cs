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
    public class CiudadesController : ControllerBase
    {

        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public CiudadesController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(bool? ciud_EsAduana)
        {
            var listado = _generalesServices.ListarCiudades(ciud_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<CiudadesViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(CiudadesViewModel CiudadesViewModel)
        {
            var item = _mapper.Map<tbCiudades>(CiudadesViewModel);
            var respuesta = _generalesServices.InsertarCiudades(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(CiudadesViewModel CiudadesViewModel)
        {
            var item = _mapper.Map<tbCiudades>(CiudadesViewModel);
            var respuesta = _generalesServices.ActualizarCiudades(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(CiudadesViewModel ciudadesViewModel)
        {
            var item = _mapper.Map<tbCiudades>(ciudadesViewModel);
            var respuesta = _generalesServices.EliminarCiudades(item);
            return Ok(respuesta);
        }

        [HttpGet("CiudadesFiltradaPorProvincias")]
        public IActionResult CiudadesPorProvincias(int pvin_Id)
        {
            var listado = _generalesServices.CiudadesPorProvincia(pvin_Id);
            listado.Data = _mapper.Map<IEnumerable<CiudadesViewModel>>(listado.Data);
            return Ok(listado);
        }

    }
}

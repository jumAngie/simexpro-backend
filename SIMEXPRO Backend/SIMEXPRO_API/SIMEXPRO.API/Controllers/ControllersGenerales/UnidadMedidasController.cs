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
    public class UnidadMedidasController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public UnidadMedidasController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(bool? unme_EsAduana)
        {
            var listado = _generalesServices.ListarUnidadMedidas(unme_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<UnidadMedidaViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(UnidadMedidaViewModel unidadMedidaViewModel)
        {
            var item = _mapper.Map<tbUnidadMedidas>(unidadMedidaViewModel);
            var respuesta = _generalesServices.InsertarUnidadMedidas(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(UnidadMedidaViewModel unidadMedidaViewModel)
        {
            var item = _mapper.Map<tbUnidadMedidas>(unidadMedidaViewModel);
            var respuesta = _generalesServices.ActualizarUnidadMedidas(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(UnidadMedidaViewModel unidadMedidaViewModel)
        {
            var item = _mapper.Map<tbUnidadMedidas>(unidadMedidaViewModel);
            var respuesta = _generalesServices.EliminarUnidadMedidas(item);
            return Ok(respuesta);
        }
    }
}

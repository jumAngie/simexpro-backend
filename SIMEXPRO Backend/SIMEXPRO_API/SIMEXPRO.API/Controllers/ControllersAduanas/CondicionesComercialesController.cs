using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionesComercialesController : ControllerBase
    {

        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public CondicionesComercialesController(AduanaServices aduanaServices, IMapper mapper)
        {
            _aduanaServices = aduanaServices;
            _mapper = mapper;
        }

        
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarCondicionesComerciales();
            listado.Data = _mapper.Map<IEnumerable<CondicionesComercialesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(CondicionesComercialesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbCondicionesComerciales>(clientesViewModel);
            var respuesta = _aduanaServices.InsertarCondicionesComerciales(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(CondicionesComercialesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbCondicionesComerciales>(clientesViewModel);
            var respuesta = _aduanaServices.ActualizarCondicionesComerciales(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(CondicionesComercialesViewModel clientesViewModel)
        {
            var item = _mapper.Map<tbCondicionesComerciales>(clientesViewModel);
            var respuesta = _aduanaServices.EliminarCondicionesComerciales(item);
            return Ok(respuesta);
        }
    }
}

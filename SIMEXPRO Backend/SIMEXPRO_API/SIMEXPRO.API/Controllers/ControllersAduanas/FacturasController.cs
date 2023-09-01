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
    public class FacturasController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public FacturasController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Listado(int deva_Id)
        {
            //var item2 = _mapper.Map<tbFacturas>(item);
            var response = _aduanaServices.ListarFacturas(deva_Id);
            return Ok(response);
        }

        [HttpGet("VerificarFactura")]
        public IActionResult VerificarFactura(string fact_Numero)
        {
            var response = _aduanaServices.VerificarFactura(fact_Numero);
            return Ok(response);
        }


        [HttpPost("Insertar")]
        public IActionResult Insertar(FacturasViewModel FacturasViewModel)
        {
            var item = _mapper.Map<tbFacturas>(FacturasViewModel);
            var respuesta = _aduanaServices.InsertarFacturas(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(FacturasViewModel FacturasViewModel)
        {
            var item = _mapper.Map<tbFacturas>(FacturasViewModel);
            var respuesta = _aduanaServices.ActualizarFacturas(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(FacturasViewModel FacturasViewModel)
        {
            var item = _mapper.Map<tbFacturas>(FacturasViewModel);
            var respuesta = _aduanaServices.EliminarFacturas(item);
            return Ok(respuesta);
        }
    }
}

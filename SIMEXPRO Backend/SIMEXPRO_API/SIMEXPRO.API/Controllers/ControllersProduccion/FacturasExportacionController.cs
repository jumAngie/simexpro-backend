using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsProduccion;
using SIMEXPRO.BussinessLogic.Services.ProduccionServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersProduccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasExportacionController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public FacturasExportacionController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarFacturasExportacion();
            listado.Data = _mapper.Map<IEnumerable<FacturasExportacionViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(FacturasExportacionViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacion>(item);
            var respuesta = _produccionServices.InsertarFacturasExportacion(mapped);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(FacturasExportacionViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacion>(item);
            var respuesta = _produccionServices.ActualizarFacturasExportacion(mapped);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(FacturasExportacionViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacion>(item);
            var respuesta = _produccionServices.EliminarFacturasExportacion(mapped);
            return Ok(respuesta);
        }
        
        [HttpPost("Finalizar")]
        public IActionResult Finalizar(FacturasExportacionViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacion>(item);
            var respuesta = _produccionServices.FinalizarFacturasExportacion(mapped);
            return Ok(respuesta);
        }

        [HttpGet("PODDL")]
        public IActionResult OrdenesCompraDDL()
        {
            var listado = _produccionServices.OrdenesCompraDDL();
            listado.Data = _mapper.Map<IEnumerable<FacturasExportacionViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("DUCADDL")]
        public IActionResult DUCAsDDL()
        {
            var listado = _produccionServices.DUCAsDDL();
            listado.Data = _mapper.Map<IEnumerable<FacturasExportacionViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

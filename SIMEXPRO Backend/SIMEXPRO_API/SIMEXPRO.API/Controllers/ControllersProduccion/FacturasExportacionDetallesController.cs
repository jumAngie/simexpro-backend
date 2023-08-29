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
    public class FacturasExportacionDetallesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public FacturasExportacionDetallesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(int faex_Id)
        {
            var listado = _produccionServices.ListarFacturasExportacionDetalles(faex_Id);
            listado.Data = _mapper.Map<IEnumerable<FacturaExportacionDetallesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(FacturaExportacionDetallesViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacionDetalles>(item);
            var respuesta = _produccionServices.InsertarFacturasExportacionDetalles(mapped);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(FacturaExportacionDetallesViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacionDetalles>(item);
            var respuesta = _produccionServices.ActualizarFacturasExportacionDetalles(mapped);
            return Ok(respuesta);
        }
        
        [HttpPost("Eliminar")]
        public IActionResult Delete(FacturaExportacionDetallesViewModel item)
        {
            var mapped = _mapper.Map<tbFacturasExportacionDetalles>(item);
            var respuesta = _produccionServices.EliminarFacturasExportacionDetalles(mapped);
            return Ok(respuesta);
        }
        
        [HttpPost("PODetallesDDL")]
        public IActionResult PODetallesDDL(FacturaExportacionDetallesViewModel id)
        {
            var listado = _produccionServices.PODetallesDDL(id.faex_Id);
            listado.Data = _mapper.Map<IEnumerable<FacturaExportacionDetallesViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

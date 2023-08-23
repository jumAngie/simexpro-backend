using AutoMapper;
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
    public class ProcesoPorOrdenCompraDetalleController : Controller
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        [HttpGet("Listar")]
        public IActionResult Index(int cade_Id)
        {
            var listado = _produccionServices.ListarProcesoOrdenCompraDetalles(cade_Id);
            listado.Data = _mapper.Map<IEnumerable<ProcesoPorOrdenCompraDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ProcesoPorOrdenCompraDetalleViewModel procesoPorOrdenCompraDetalleViewModel)
        {
            var item = _mapper.Map<tbProcesoPorOrdenCompraDetalle>(procesoPorOrdenCompraDetalleViewModel);
            var respuesta = _produccionServices.InsertarProcesoOrdenCompraDetalles(item);
            return Ok(respuesta);
        }
    }
}

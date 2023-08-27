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
    public class LotesController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public LotesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarLotes();
            listado.Data = _mapper.Map<IEnumerable<LotesViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(LotesViewModel lotesViewModel)
        {
            var item = _mapper.Map<tbLotes>(lotesViewModel);
            var respuesta = _produccionServices.InsertarLotes(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(LotesViewModel lotesViewModel)
        {
            var item = _mapper.Map<tbLotes>(lotesViewModel);
            var respuesta = _produccionServices.ActualizarLotes(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(LotesViewModel lotesViewModel)
        {
            var item = _mapper.Map<tbLotes>(lotesViewModel);
            var respuesta = _produccionServices.EliminarLotes(item);
            return Ok(respuesta);
        }

        [HttpGet("LotesMateriales")]
        public IActionResult LotesMateriales(string lote_CodigoLote)
        {
            var listado = _produccionServices.LotesMateriales(lote_CodigoLote);
            listado.Data = _mapper.Map<IEnumerable<LotesViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

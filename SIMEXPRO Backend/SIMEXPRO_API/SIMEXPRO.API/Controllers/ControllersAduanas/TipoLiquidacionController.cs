using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
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
    public class TipoLiquidacionController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public TipoLiquidacionController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarTipoLiquidacion();
            listado.Data = _mapper.Map<IEnumerable<TipoLiquidacionViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(TipoLiquidacionViewModel tipoLiquidacionViewModel)
        {
            var item = _mapper.Map<tbTipoLiquidacion>(tipoLiquidacionViewModel);
            var respuesta = _aduanaServices.InsertarTipoLiquidacion(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(TipoLiquidacionViewModel tipoLiquidacionViewModel)
        {
            var item = _mapper.Map<tbTipoLiquidacion>(tipoLiquidacionViewModel);
            var respuesta = _aduanaServices.ActualizarTipoLiquidacion(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(TipoLiquidacionViewModel tipoLiquidacionViewModel)
        {
            var item = _mapper.Map<tbTipoLiquidacion>(tipoLiquidacionViewModel);
            var respuesta = _aduanaServices.EliminarTipoLiquidacion(item);
            return Ok(respuesta);
        }
    }
}

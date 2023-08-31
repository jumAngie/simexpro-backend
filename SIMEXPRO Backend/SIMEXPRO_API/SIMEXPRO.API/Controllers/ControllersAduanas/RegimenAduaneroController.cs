using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.Entities.Entities;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]

    public class RegimenAduaneroController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public RegimenAduaneroController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarRegimenesAduaneros();
            listado.Data = _mapper.Map<IEnumerable<RegimenesAduanerosViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(RegimenesAduanerosViewModel regimenesAduanerosViewModel)
        {
            var item = _mapper.Map<tbRegimenesAduaneros>(regimenesAduanerosViewModel);
            var respuesta = _aduanaServices.InsertarRegimenesAduaneros(item);
            return Ok(respuesta);
        }
        [HttpPost("Editar")]
        public IActionResult Update(RegimenesAduanerosViewModel regimenesAduanerosViewModel)
        {
            var item = _mapper.Map<tbRegimenesAduaneros>(regimenesAduanerosViewModel);
            var respuesta = _aduanaServices.ActualizarRegimenesAduaneros(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(RegimenesAduanerosViewModel regimenesAduanerosViewModel)
        {
            var item = _mapper.Map<tbRegimenesAduaneros>(regimenesAduanerosViewModel);
            var respuesta = _aduanaServices.EliminarRegimenesAduaneros(item);
            return Ok(respuesta);
        }
    }
}

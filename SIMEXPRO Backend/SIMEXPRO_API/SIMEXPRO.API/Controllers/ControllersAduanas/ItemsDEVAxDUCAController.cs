    using AutoMapper;
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

    public class ItemsDEVAxDUCAController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ItemsDEVAxDUCAController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("ListarDevaPorDucaNo")]
        public IActionResult ListarDevaPorDucaNo(int duca_Id)
        {
            var listado = _aduanaServices.ListarDeclaraciones_ValorPorDucaNo(duca_Id);
            return Ok(listado);
        }

        [HttpGet("ListadoDevasPorducaId")]
        public IActionResult ListadoDevas(int duca_Id)
        {
            var listado = _aduanaServices.ListadoDevasPorducaId(duca_Id);

            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ItemsDEVAxDUCAViewModel modelo)
        {
            var item = _mapper.Map<tbItemsDEVAPorDuca>(modelo);
            var respuesta = _aduanaServices.InsertarItemsDEVAxDUCA(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ItemsDEVAxDUCAViewModel modelo)
        {
            var item = _mapper.Map<tbItemsDEVAPorDuca>(modelo);
            var respuesta = _aduanaServices.ActualizarItemsDEVAxDUCA(item);
            return Ok(respuesta);
        }

        [HttpPost("LiberarDevasPorDucaId")]
        public IActionResult LiberarDevasPorDucaId(int duca_Id)
        {
            var respuesta = _aduanaServices.LiberarDevasPorDucaId(duca_Id);
            return Ok(respuesta);
        }
    }
}

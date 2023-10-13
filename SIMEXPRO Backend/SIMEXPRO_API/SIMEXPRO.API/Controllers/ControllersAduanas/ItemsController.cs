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
    public class ItemsController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ItemsController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(int fact_Id)
        {
            var respuesta = _aduanaServices.ListarItems(fact_Id);
            respuesta.Data = _mapper.Map<IEnumerable<ItemsViewModel>>(respuesta.Data);

            return Ok(respuesta);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(ItemsViewModel concepto)
        {
            var item = _mapper.Map<tbItems>(concepto);

            var respuesta = _aduanaServices.InsertarItems(item);

            return Ok(respuesta);
        }

        [HttpPost("EditarItemDuca")]
        public IActionResult EditarItemDuca(ItemsViewModel item)
        {
            var respuesta = _aduanaServices.ActualizarItemDuca(_mapper.Map<tbItems>(item));

            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ItemsViewModel concepto)
        {
            var item = _mapper.Map<tbItems>(concepto);

            var respuesta = _aduanaServices.ActualizarItems(item);

            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ItemsViewModel concepto)
        {
            var item = _mapper.Map<tbItems>(concepto);

            var respuesta = _aduanaServices.EliminarItems(item);

            return Ok(respuesta);
        }

        [HttpPost("ItemsOrdenPedido")]
        public IActionResult ItemsOrdenPedido(string id)
        {
            var respuesta = _aduanaServices.ItemsOrdenPedido(id);

            return Ok(respuesta);
        }

        [HttpPost("CalcularValorAduana")]
        public IActionResult CalcularValorAduana(int item_Id, int trli_Id, int duca_Id, decimal deva_ConversionDolares)
        {
            var respuesta = _aduanaServices.CalcularValorAduana(item_Id, trli_Id, duca_Id, deva_ConversionDolares);

            return Ok(respuesta);
        }
    }
}

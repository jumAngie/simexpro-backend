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
    public class ArancelesPorTratadoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public ArancelesPorTratadoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("ListarAcuerdosPorTratado")]
        public IActionResult ListarAcuerdosPorTratado(int tratado, string capitulo)
        {
            var list = _aduanaServices.ListarAcuerdosPorTratado(tratado, capitulo);
            list.Data = _mapper.Map<IEnumerable<ArancelesPorTratadoViewModel>>(list.Data);
            return Ok(list);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(ArancelesPorTratadoViewModel item)
        {
            var data = _mapper.Map<tbArancelesPorTratados>(item);
            var response = _aduanaServices.InsertarArancelPorTratado(data);
            return Ok(response);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ArancelesPorTratadoViewModel item)
        {
            var data = _mapper.Map<tbArancelesPorTratados>(item);
            var response = _aduanaServices.EditarArancelPorTratado(data);
            return Ok(response);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ArancelesPorTratadoViewModel item)
        {
            var data = _mapper.Map<tbArancelesPorTratados>(item);
            var response = _aduanaServices.EliminarArancelPorTratado(data);
            return Ok(response);
        }


    }
}

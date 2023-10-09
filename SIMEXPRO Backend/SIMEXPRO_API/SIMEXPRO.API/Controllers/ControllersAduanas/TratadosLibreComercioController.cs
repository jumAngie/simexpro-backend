using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class TratadosLibreComercioController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public TratadosLibreComercioController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("ListTratadosById")]
        public IActionResult ListById(int trli_Id)
        {
            var list = _aduanaServices.LisTratadosById(trli_Id);
            list.Data = _mapper.Map<IEnumerable<TratadosLibreComercioViewModel>>(list.Data);
            return Ok(list);
        }
    }
}

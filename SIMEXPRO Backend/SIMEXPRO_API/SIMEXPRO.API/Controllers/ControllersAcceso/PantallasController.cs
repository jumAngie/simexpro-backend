using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAcceso;
using SIMEXPRO.BussinessLogic.Services.AccesoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantallasController : ControllerBase
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public PantallasController(AccesoServices accesoService, IMapper mapper)
        {
            _accesoServices = accesoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(bool? pant_EsAduana)
        {
            var listado = _accesoServices.ListarPantallas(pant_EsAduana);

            listado.Data = _mapper.Map<IEnumerable<PantallasViewModel>>(listado.Data);

            return Ok(listado);
        }
    }
}

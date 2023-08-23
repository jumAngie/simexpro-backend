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
    public class OrdeEnsaAcabEtiqController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public OrdeEnsaAcabEtiqController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.Listarorde_Ensa_Acab_Etiq();
            listado.Data = _mapper.Map<IEnumerable<OrdeEnsaAcabEtiqViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(OrdeEnsaAcabEtiqViewModel ordeEnsaAcabEtiqViewModel)
        {
            var item = _mapper.Map<tbOrde_Ensa_Acab_Etiq>(ordeEnsaAcabEtiqViewModel);
            var respuesta = _produccionServices.Insertarorde_Ensa_Acab_Etiq(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(OrdeEnsaAcabEtiqViewModel ordeEnsaAcabEtiqViewModel)
        {
            var item = _mapper.Map<tbOrde_Ensa_Acab_Etiq>(ordeEnsaAcabEtiqViewModel);
            var respuesta = _produccionServices.Actualizarorde_Ensa_Acab_Etiq(item);
            return Ok(respuesta);
        }


    }
}

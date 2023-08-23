using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
using SIMEXPRO.BussinessLogic.Services.GeneralServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersGenerales
{

    [Route("api/[controller]")]
    [ApiController]

    public class FormasEnvioController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public FormasEnvioController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
        
        
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _generalesServices.ListarFormas_Envio();
            listado.Data = _mapper.Map<IEnumerable<Formas_EnvioViewModel>>(listado.Data);
            return Ok(listado);

        }


        [HttpPost("Insertar")]
        public IActionResult Insert(Formas_EnvioViewModel formas_EnvioViewModel)
        {
            var item = _mapper.Map<tbFormas_Envio>(formas_EnvioViewModel);
            var respuesta = _generalesServices.InsertarFormas_Envio(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(Formas_EnvioViewModel formas_EnvioViewModel)
        {
            var item = _mapper.Map<tbFormas_Envio>(formas_EnvioViewModel);
            var respuesta = _generalesServices.ActualizarFormas_Envio(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(Formas_EnvioViewModel formas_EnvioViewModel)
        {
            var item = _mapper.Map<tbFormas_Envio>(formas_EnvioViewModel);         
            var respuesta = _generalesServices.EliminarFormas_Envio(item);
            return Ok(respuesta);
        }
    }
}

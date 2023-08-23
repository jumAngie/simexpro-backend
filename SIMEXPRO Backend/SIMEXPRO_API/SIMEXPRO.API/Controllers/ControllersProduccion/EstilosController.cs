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
    public class EstilosController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public EstilosController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarEstilos();
            listado.Data = _mapper.Map<IEnumerable<EstilosViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(EstilosViewModel estilosViewModel)
        {
            var item = _mapper.Map<tbEstilos>(estilosViewModel);
            var respuesta = _produccionServices.InsertarEstilos(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(EstilosViewModel estilosViewModel)
        {
            var item = _mapper.Map<tbEstilos>(estilosViewModel);
            var respuesta = _produccionServices.ActualizarEstilos(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(EstilosViewModel estilosViewModel)
        {
            var item = _mapper.Map<tbEstilos>(estilosViewModel);
            var respuesta = _produccionServices.EliminarEstilos(item);
            return Ok(respuesta);
        }

    

        
    


    }
}

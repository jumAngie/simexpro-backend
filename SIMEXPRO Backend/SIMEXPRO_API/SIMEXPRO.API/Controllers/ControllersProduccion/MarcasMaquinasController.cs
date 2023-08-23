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
    public class MarcasMaquinasController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public MarcasMaquinasController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarMarcasMaquina();
            listado.Data = _mapper.Map<IEnumerable<MarcasMaquinaViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(MarcasMaquinaViewModel marcasMaquinaViewModel)
        {
            var item = _mapper.Map<tbMarcasMaquina>(marcasMaquinaViewModel);
            var respuesta = _produccionServices.InsertarMarcasMaquina(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(MarcasMaquinaViewModel marcasMaquinaViewModel)
        {
            var item = _mapper.Map<tbMarcasMaquina>(marcasMaquinaViewModel);
            var respuesta = _produccionServices.ActualizaMarcasMaquina(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(MarcasMaquinaViewModel marcasMaquinaViewModel)
        {
            var item = _mapper.Map<tbMarcasMaquina>(marcasMaquinaViewModel);
            var respuesta = _produccionServices.EliminarMarcasMaquina(item);
            return Ok(respuesta);
        }

    }
}

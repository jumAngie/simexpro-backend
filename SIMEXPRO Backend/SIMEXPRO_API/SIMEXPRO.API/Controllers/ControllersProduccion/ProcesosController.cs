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
    public class ProcesosController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public ProcesosController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _produccionServices.ListarProcesos();
            listado.Data = _mapper.Map<IEnumerable<ProcesosViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(ProcesosViewModel ProcesosViewModel)
        {
            var item = _mapper.Map<tbProcesos>(ProcesosViewModel);
            var respuesta = _produccionServices.InsertarProcesos(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(ProcesosViewModel ProcesosViewModel)
        {
            var item = _mapper.Map<tbProcesos>(ProcesosViewModel);
            var respuesta = _produccionServices.ActualizarProcesos(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(ProcesosViewModel ProcesosViewModel)
        {
            var item = _mapper.Map<tbProcesos>(ProcesosViewModel);
            var respuesta = _produccionServices.EliminarProcesos(item);
            return Ok(respuesta);
        }

        [HttpGet("Filtrar")]
        public IActionResult Filtrar(int proc_Id)
        {
            var listado = _produccionServices.FiltrarProcesos(proc_Id);
            listado.Data = _mapper.Map<IEnumerable<ProcesosViewModel>>(listado.Data);
            return Ok(listado);
        }
    }
}

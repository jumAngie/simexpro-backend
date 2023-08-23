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
    public class EmpleadosController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public EmpleadosController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index(bool? empl_EsAduana)
        {
            var listado = _generalesServices.ListarEmpleados(empl_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<EmpleadosViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpGet("ListarNoTieneUsuario")]
        public IActionResult IndexSinUsuario(bool? empl_EsAduana)
        {
            var listado = _generalesServices.ListarEmpleadosSinUsuario(empl_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<EmpleadosViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(EmpleadosViewModel empleadosViewModel)
        {
            var item = _mapper.Map<tbEmpleados>(empleadosViewModel);
            var respuesta = _generalesServices.InsertarEmpleados(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(EmpleadosViewModel empleadosViewModel)
        {
            var item = _mapper.Map<tbEmpleados>(empleadosViewModel);
            var respuesta = _generalesServices.ActualizarEmpleados(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(EmpleadosViewModel empleadosViewModel)
        {
            var item = _mapper.Map<tbEmpleados>(empleadosViewModel);
            var respuesta = _generalesServices.EliminarEmpleados(item);
            return Ok(respuesta);
        }

        [HttpPost("Reactivar")]
        public IActionResult Reactivar(EmpleadosViewModel empleadosViewModel)
        {
            var item = _mapper.Map<tbEmpleados>(empleadosViewModel);
            var respuesta = _generalesServices.ReactivarEmpleados(item);
            return Ok(respuesta);
        }
    }
}

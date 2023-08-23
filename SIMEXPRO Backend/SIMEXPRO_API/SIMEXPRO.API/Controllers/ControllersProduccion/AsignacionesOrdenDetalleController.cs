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
    public class AsignacionesOrdenDetalleController : ControllerBase
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public AsignacionesOrdenDetalleController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(int asor_Id)
        {
            var listado = _produccionServices.ListarAsignacionOrdenDetalle(asor_Id);
            listado.Data = _mapper.Map<IEnumerable<AsignacionesOrdenDetalleViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(AsignacionesOrdenDetalleViewModel asignacionesOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbAsignacionesOrdenDetalle>(asignacionesOrdenDetalleViewModel);
            var respuesta = _produccionServices.InsertarAsignacionOrdenDetalle(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(AsignacionesOrdenDetalleViewModel asignacionesOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbAsignacionesOrdenDetalle>(asignacionesOrdenDetalleViewModel);
            var respuesta = _produccionServices.ActualizarAsignacionOrdenDetalle(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(AsignacionesOrdenDetalleViewModel asignacionesOrdenDetalleViewModel)
        {
            var item = _mapper.Map<tbAsignacionesOrdenDetalle>(asignacionesOrdenDetalleViewModel);
            var respuesta = _produccionServices.EliminarAsignacionOrdenDetalle(item);
            return Ok(respuesta);
        }

    }
}

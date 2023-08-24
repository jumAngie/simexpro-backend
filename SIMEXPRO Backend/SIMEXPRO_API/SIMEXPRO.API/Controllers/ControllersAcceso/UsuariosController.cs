using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAcceso;
using SIMEXPRO.BussinessLogic.Services.AccesoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public UsuariosController(AccesoServices accesoService, IMapper mapper)
        {
            _accesoServices = accesoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index(bool? empl_EsAduana)
        {          
            var listado = _accesoServices.ListarUsuarios(empl_EsAduana);
            listado.Data = _mapper.Map<IEnumerable<UsuariosViewModel>>(listado.Data);
            return Ok(listado);

        }

        [HttpPost("Login")]
        public IActionResult InicioSesion(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var respuesta = _accesoServices.IniciarSesion(mapped);

            if (respuesta.Code == 200)
            {
                respuesta.Data = _mapper.Map<UsuariosViewModel>(respuesta.Data);

                return Ok(respuesta);

            }
            else
            {
                return StatusCode(203, respuesta);
            }
        }

        [HttpGet("UsuarioCorreo")]
        public IActionResult UsuarioCorreo(string usua_Nombre)
        {
            var respuesta = _accesoServices.UsuarioCorreo(usua_Nombre);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return NotFound(respuesta);
            }
        }

        [HttpPost("CambiarContrasenia")]
        public IActionResult CambiarContrasenia(UsuariosViewModel item)
        {
            var mapped = _mapper.Map<tbUsuarios>(item);
            var respuesta = _accesoServices.CambiarContrasenia(mapped);

            if (respuesta.Code == 200)
            {
                return Ok(respuesta);
            }
            else
            {
                return BadRequest(respuesta);
            }
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var datos = _accesoServices.InsertarUsuario(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var datos = _accesoServices.ActualizarUsuario(mapped);
            return Ok(datos);
        }

        [HttpPost("Activar")]
        public IActionResult Activar(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var datos = _accesoServices.ActivarEstadoUsuario(mapped);
            return Ok(datos);
        }


        [HttpPost("Eliminar")]
        public IActionResult Eliminar(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var datos = _accesoServices.DeleteUsuario(mapped);
            return Ok(datos);
        }

        [HttpPost("CambiarPerfil")]
        public IActionResult CambiarFotoPerfil(UsuariosViewModel usuarios)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuarios);
            var datos = _accesoServices.CambiarPerfilUsuario(mapped);
            return Ok(datos);
        }
    }
}

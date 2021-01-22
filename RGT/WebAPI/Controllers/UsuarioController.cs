using Contexto.Data;
using Contexto.Data.Interface;
using Contexto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        //[HttpGet("id")]
        //[Route("get")]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _usuarioRepository.GetTodosUsuarios();
            return Ok(usuarios);
        }
    }
}

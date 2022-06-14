using LogicaDeNegocio;
using managerProjects.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Utilitarios;

namespace managerProjects.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]


	[RoutePrefix("api/login")]
	public class LoginController : ApiController
    {
		[HttpPost]
		[Route("PostIngresoLogin")]
		public IHttpActionResult PostIngresoLogin(UUsuario usuarioAcceso)
		{
			try
			{
				UUsuario usuario = new LIngresoLogin().getUsuarioAcceso(usuarioAcceso);
				if (usuario != null)
				{
					string token = TokenGenerator.GenerateTokenJwt(usuario);
					return Ok(token);
				}
				return NotFound();
				
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
    }
}

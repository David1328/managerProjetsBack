using LogicaDeNegocio;
using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Utilitarios;

namespace managerProjects.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]

	[RoutePrefix("api/usuario")]
	public class UsuarioController : ApiController
    {
		//Servicios para agregar usuario nuevo
		[HttpPost]
		[Route("PostNuevoUsuario")]
		public IHttpActionResult PostNuevoUsuario(UUsuario usuarioNuevo)
		{
			try
			{
				string mensaje = new LUsuarios().agregarUsuarios(usuarioNuevo);
				if (mensaje != null)
				{
					return Ok(mensaje);
				}
				return Conflict();
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
	}
}

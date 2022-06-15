using LogicaDeNegocio;
using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Utilitarios;

namespace managerProjects.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]

	[RoutePrefix("api/proyecto")]
	public class ProyectoController : ApiController
    {
		[HttpPost]
		[Route("PostNuevoProyecto")]
		public IHttpActionResult PostNuevoProyecto(UProyecto nuevoProyecto)
		{
			try
			{
				string mensaje = new LProyecto().agregarProyecto(nuevoProyecto);
				if (mensaje!= null)
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
		[HttpGet]
		[Route("GetListaProyectos")]
		public IHttpActionResult GetListaProyectos()
		{
			try
			{
				if (new LProyecto().obtenerProyectos() != null)
				{
					return Ok(new LProyecto().obtenerProyectos());
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

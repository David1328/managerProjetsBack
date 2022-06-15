using LogicaDeNegocio;
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

	[RoutePrefix("api/ticket")]
	public class TicketController : ApiController
    {
		/*[HttpGet]
		[Route("GetHistoriasDeUsuario")]
		public IHttpActionResult GetHistoriasDeUsuario()
		{
			try
			{
				return Ok(new LHistoriaDeUsuario().obtenerHistorias());
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}*/
		[HttpPost]
		[Route("PostNuevoTicket")]
		public IHttpActionResult PostNuevoTicket(UTicket nuevoTicket)
		{
			try
			{
				return Ok(new LTicket().agregarNuevoTicket(nuevoTicket));
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
	}
}

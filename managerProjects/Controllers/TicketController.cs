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
		[HttpGet]
		[Route("GetTicketsDeLaHistoria/{id_historia}")]
		public IHttpActionResult GetTicketsDeLaHistoria(int id_historia)
		{
			try
			{
				return Ok(new LTicket().obtenerTicketsDeLaHistoria(id_historia));
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}

		[HttpGet]
		[Route("GetlistaEstados")]
		public IHttpActionResult GetlistaEstados()
		{
			try
			{
				return Ok(new LTicket().listaDeEstados());
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}

		[HttpGet]
		[Route("GetTicketDeLaHistoria/{id_historia}/{id_ticket}")]
		public IHttpActionResult GetTicketsDeLaHistoria(int id_historia,double id_ticket)
		{
			try
			{
				return Ok(new LTicket().obtenerTicketDeLaHistoria(id_historia,id_ticket));
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
		[HttpPost]
		[Route("PostNuevoTicket")]
		public IHttpActionResult PostNuevoTicket(UHistoriaDeUsuario nuevoTicket)
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
		[HttpPut]
		[Route("PutActualizarTicket")]
		public IHttpActionResult PutActualizarTicket(UHistoriaDeUsuario ticketParaActualizar)
		{
			try
			{
				return Ok(new LTicket().actualizarTicket(ticketParaActualizar));
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
	}
}

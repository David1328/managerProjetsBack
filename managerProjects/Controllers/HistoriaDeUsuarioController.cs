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

	[RoutePrefix("api/historiaDeUsuario")]
	public class HistoriaDeUsuarioController : ApiController
    {

		[HttpGet]
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
		}
		[HttpPost]
		[Route("PostNuevaHistoria")]
		public IHttpActionResult PostNuevaHistoria(UHistoriaDeUsuario nuevaHistoria)
		{
			try
			{
				return Ok(new LHistoriaDeUsuario().agregarNuevaHistoria(nuevaHistoria));
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}

	}
}

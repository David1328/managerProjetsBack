using LogicaDeNegocio;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace managerProjects
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]

	[RoutePrefix("api/empresa")]
	public class EmpresaController : ApiController
	{
		[HttpGet]
		[Route("GetListCompany")]
		public IHttpActionResult getListCompany()
		{
			try
			{
				return Ok(new LEmpresa().getlistEmpresa());
			}
			catch (Exception ex)
			{
				return BadRequest("surgio el siguente error: " + ex.Message.ToString());
			}
		}
	}
}
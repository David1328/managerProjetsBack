using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Utilitarios;

namespace Datos
{
	public class HistoriaDeUsuario
	{
		public List<UHistoriaDeUsuario> obtenerHistoriasDeUsuario()
		{
			using (var db = new Mapping())
			{
				List<UHistoriaDeUsuario> listaProyecto = (from h in db.uHistoriaDeUsuario
														  join p in db.uProyecto on h.Proyecto_id equals p.Id_proyecto

														  select new
														  {
															  h,
															  p
														  }).ToList().Select(m => new UHistoriaDeUsuario
														  {
															  Id_historia = m.h.Id_historia,
															  Historia = m.h.Historia,
															  Empresa_id = m.h.Empresa_id,
															  Proyecto_id = m.h.Proyecto_id,
															  Proyecto = m.p.Nombre_proyecto
														  }).ToList();
				return listaProyecto;

			}
		}
		public void agregarHistorias(UHistoriaDeUsuario nuevaHistoria)
		{
			using (var db = new Mapping())
			{
				List<UTicket> ticketsEnHistoria = new List<UTicket>();
				ticketsEnHistoria.Add(nuevaHistoria.NuevosTickets);
				nuevaHistoria.Tickes = JsonConvert.SerializeObject(ticketsEnHistoria, Formatting.Indented, new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				});

				db.uHistoriaDeUsuario.Add(nuevaHistoria);
				db.SaveChanges();
			}
		}
	}
}

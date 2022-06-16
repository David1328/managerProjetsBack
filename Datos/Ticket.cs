using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Datos
{
	public class Ticket
	{
		public string agregarTicket(UHistoriaDeUsuario nuevoTicket)
		{
			using (var db = new Mapping())
			{
				UHistoriaDeUsuario uHistoria = db.uHistoriaDeUsuario.Where(x => x.Id_historia.Equals(nuevoTicket.Id_historia)).FirstOrDefault();
				if (uHistoria.Tickes != null)
				{
					List<UTicket> ticketsDeLaHistoria = JsonConvert.DeserializeObject<List<UTicket>>(uHistoria.Tickes);
					ticketsDeLaHistoria.Add(nuevoTicket.NuevosTickets);
					uHistoria.Tickes = JsonConvert.SerializeObject(ticketsDeLaHistoria, Formatting.Indented, new JsonSerializerSettings
					{
						NullValueHandling = NullValueHandling.Ignore
					});
					var enty = db.Entry(uHistoria);
					enty.State = EntityState.Modified;
					db.SaveChanges();
					return "Se guardo el ticket con exito";
				}
				return "Ha ocurrido un error";
			}
		}
		public List<UTicket> obtenerTickets(int id_historia)
		{
			using (var db = new Mapping())
			{
				if (id_historia==0)
				{
					return null;
				}
				UHistoriaDeUsuario historia = db.uHistoriaDeUsuario.Where(x => x.Id_historia.Equals(id_historia)).FirstOrDefault();
				List<UTicket> ticketsDeLaHistoria = JsonConvert.DeserializeObject<List<UTicket>>(historia.Tickes);
				return ticketsDeLaHistoria;
			}
		}
		public UTicket obtenerTicket(int id_historia, double id_ticket)
		{
			using (var db = new Mapping())
			{
				UHistoriaDeUsuario uHistoria = db.uHistoriaDeUsuario.Where(x => x.Id_historia.Equals(id_historia)).FirstOrDefault();
				if (uHistoria.Tickes != null)
				{
					List<UTicket> ticketsDeLaHistoria = JsonConvert.DeserializeObject<List<UTicket>>(uHistoria.Tickes);
					return ticketsDeLaHistoria.Where(x => x.Id_ticket.Equals(id_ticket)).FirstOrDefault();
				}
				return null;
			}
		}
		public void actualizarTicket(UHistoriaDeUsuario ticketParaActualizar)
		{
			using (var db = new Mapping())
			{
				UHistoriaDeUsuario uHistoria = db.uHistoriaDeUsuario.Where(x => x.Id_historia.Equals(ticketParaActualizar.Id_historia)).FirstOrDefault();
				if (uHistoria.Tickes != null)
				{
					List<UTicket> ticketsDeLaHistoria = JsonConvert.DeserializeObject<List<UTicket>>(uHistoria.Tickes);
					foreach(UTicket ticket in ticketsDeLaHistoria)
					{
						if (ticket.Id_ticket.Equals(ticketParaActualizar.NuevosTickets.Id_ticket))
						{
							ticket.Comentario = ticketParaActualizar.NuevosTickets.Comentario;
							ticket.Estado = ticketParaActualizar.NuevosTickets.Estado;
						}
					}
					uHistoria.Tickes = JsonConvert.SerializeObject(ticketsDeLaHistoria, Formatting.Indented, new JsonSerializerSettings
					{
						NullValueHandling = NullValueHandling.Ignore
					});
					var enty = db.Entry(uHistoria);
					enty.State = EntityState.Modified;
					db.SaveChanges();
				}
			}
		}
		public List<UEstado> estados()
		{
			return new Mapping().uEstado.ToList();
		}
	}
}

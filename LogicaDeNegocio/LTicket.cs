using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LTicket
	{
		public string agregarNuevoTicket(UHistoriaDeUsuario nuevoTicket)
		{
			DateTime id_ticket = DateTime.Now;
			string id_ticket_texto = id_ticket.ToString("u").Replace("Z", "").Replace(":", "").Replace(" ", "").Replace("-", "");
			nuevoTicket.NuevosTickets.Id_ticket = double.Parse(id_ticket_texto);
			nuevoTicket.NuevosTickets.Estado = "Activo";
			return new Ticket().agregarTicket(nuevoTicket);
		}
		public List<UTicket> obtenerTicketsDeLaHistoria(int id_historia)
		{
			return new Ticket().obtenerTickets(id_historia);
		}
		public UTicket obtenerTicketDeLaHistoria(int id_historia,double id_ticket)
		{
			return new Ticket().obtenerTicket(id_historia,id_ticket);
		}
		public string actualizarTicket(UHistoriaDeUsuario ticketActualizar)
		{
			new Ticket().actualizarTicket(ticketActualizar);
			return "Ticket Actualizado";
		}
		public List<UEstado> listaDeEstados()
		{
			return new Ticket().estados();
		}
	}
}

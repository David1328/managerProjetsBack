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
		public string agregarNuevoTicket(UTicket nuevoTicket)
		{
			new Ticket().agregarTicket(nuevoTicket);
			return "Nuevo Ticket Agregado";
		}
	}
}

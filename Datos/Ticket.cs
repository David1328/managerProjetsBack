using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Datos
{
	public class Ticket
	{
		public void agregarTicket(UTicket nuevoTicket)
		{
			using (var db = new Mapping())
			{
				db.uTicket.Add(nuevoTicket);
				db.SaveChanges();
			}
		}
	}
}

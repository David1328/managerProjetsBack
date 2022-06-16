

using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
	public class UTicket
	{
		private double id_ticket;
		private string comentario;
		private string estado;

		public double Id_ticket { get => id_ticket; set => id_ticket = value; }
		public string Comentario { get => comentario; set => comentario = value; }
		public string Estado { get => estado; set => estado = value; }
	}
}

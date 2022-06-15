using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
	[Serializable]
	[Table("historia_de_usuario",Schema ="proyectos")]
	public class UHistoriaDeUsuario
	{
		private int id_historia;
		private string historia;
		private int empresa_id;
		private int proyecto_id;
		private string proyecto;
		private string tickes;
		private UTicket nuevosTickets;

		[Key]
		[Column("id_historia")]
		public int Id_historia { get => id_historia; set => id_historia = value; }
		[Column("historia")]
		public string Historia { get => historia; set => historia = value; }
		[Column("empresa_id")]
		public int Empresa_id { get => empresa_id; set => empresa_id = value; }
		[Column("proyecto_id")]
		public int Proyecto_id { get => proyecto_id; set => proyecto_id = value; }
		[Column("json_ticket")]
		public string Tickes { get => tickes; set => tickes = value; }

		[NotMapped]
		public string Proyecto { get => proyecto; set => proyecto = value; }
		[NotMapped]
		public UTicket NuevosTickets { get => nuevosTickets; set => nuevosTickets = value; }
	}
}

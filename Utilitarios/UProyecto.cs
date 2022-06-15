using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
	[Serializable]
	[Table("proyecto",Schema = "proyectos")]
	public class UProyecto
	{
		private int id_proyecto;
		private string nombre_proyecto;
		private int empresa_id;
		private string usuario_id;
		private string nombre_usuario;

		[Key]
		[Column("id_proyecto")]
		public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
		[Column("nombre")]
		public string Nombre_proyecto { get => nombre_proyecto; set => nombre_proyecto = value; }
		[Column("empresa_id")]
		public int Empresa_id { get => empresa_id; set => empresa_id = value; }
		[Column("usuario_id")]
		public string Usuario_id { get => usuario_id; set => usuario_id = value; }
		[NotMapped]
		public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
	}
}

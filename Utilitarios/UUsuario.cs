using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
	[Serializable]
	[Table("usuario", Schema = "usuarios")]
	public class UUsuario
	{
		private int id_usuario;
		private string nombre;
		private string apellido;
		private string documento;
		private string clave;
		private int id_empresa;

		[Key]
		[Column("id_usuario")]
		public int Id_usuario { get => id_usuario; set => id_usuario = value; }
		[Column("nombre")]
		public string Nombre { get => nombre; set => nombre = value; }
		[Column("apellido")]
		public string Apellido { get => apellido; set => apellido = value; }
		[Column("documento")]
		public string Documento { get => documento; set => documento = value; }
		[Column("clave")]
		public string Clave { get => clave; set => clave = value; }
		[Column("id_empresa")]
		public int Id_empresa { get => id_empresa; set => id_empresa = value; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
	[Serializable]
	[Table("estado",Schema ="proyectos")]
	public class UEstado
	{
		private int id_estado;
		private string estado;

		[Key]
		[Column("id_estado")]
		public int Id_estado { get => id_estado; set => id_estado = value; }
		[Column("estado")]
		public string Estado { get => estado; set => estado = value; }
	}
}

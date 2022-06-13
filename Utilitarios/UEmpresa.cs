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
	[Table("empresa", Schema = "empresas")]
	public class UEmpresa
	{
		private int id_empresa;
		private string nombre_empresa;
		private string nit_empresa;
		private string telefono_empresa;
		private string direccion_empresa;
		private string correo_empresa;

		[Key]
		[Column("id_empresa")]
		public int Id_empresa { get => id_empresa; set => id_empresa = value; }
		[Column("nombre")]
		public string Nombre_empresa { get => nombre_empresa; set => nombre_empresa = value; }
		[Column("nit")]
		public string Nit_empresa { get => nit_empresa; set => nit_empresa = value; }
		[Column("telefono")]
		public string Telefono_empresa { get => telefono_empresa; set => telefono_empresa = value; }
		[Column("direccion")]
		public string Direccion_empresa { get => direccion_empresa; set => direccion_empresa = value; }
		[Column("correo")]
		public string Correo_empresa { get => correo_empresa; set => correo_empresa = value; }

	}
}

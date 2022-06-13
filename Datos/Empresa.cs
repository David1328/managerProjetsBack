using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Datos
{
	public class Empresa
	{
		public List<UEmpresa> obtenerListaEmpresa()
		{
			return new Mapping().uEmpresa.ToList();
		}
	}
}

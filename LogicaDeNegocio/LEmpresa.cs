using Datos;
using System.Collections.Generic;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LEmpresa
	{
		public List<UEmpresa> getlistEmpresa()
		{
			return new Empresa().obtenerListaEmpresa();
		}
	}
}

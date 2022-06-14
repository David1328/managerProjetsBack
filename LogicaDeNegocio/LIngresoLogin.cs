using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LIngresoLogin
	{
		public UUsuario getUsuarioAcceso(UUsuario usuarioAcceso)
		{
			return new Login().GetUsuario(usuarioAcceso);
		}
	}
}

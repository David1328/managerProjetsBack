using System;
using System.Linq;
using Utilitarios;

namespace Datos
{
	public class Login
	{
		public UUsuario GetUsuario(UUsuario usuarioAcceso)
		{
			return new Mapping().user.Where(x => x.Documento.Equals(usuarioAcceso.Documento) && x.Clave.Equals(usuarioAcceso.Clave)).FirstOrDefault();
		}
	}
}

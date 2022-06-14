using Datos;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LUsuarios
	{
		//agregar usuarios
		public string agregarUsuarios(UUsuario usuarioNuevo)
		{
			if (new Usuario().existeUsuario(usuarioNuevo) == null)
			{
				new Usuario().agregarUsuarioNuevo(usuarioNuevo);
				return "Registro Exitoso";
			}
			else
			{
				return null;
			}

		}
	}
}

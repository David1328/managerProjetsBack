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

		//Obtener información del usuario
		public UUsuario getInformacionUsuario(string documento)
		{
			UUsuario usuarioInformacion = new UUsuario();
			usuarioInformacion.Documento = documento;
			if (new Usuario().existeUsuario(usuarioInformacion) != null)
			{
				usuarioInformacion = new Usuario().existeUsuario(usuarioInformacion);
				return usuarioInformacion;
			}
			else
			{
				return null;
			}

		}

	}
}

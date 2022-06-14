using System.Linq;
using Utilitarios;

namespace Datos
{
	public class Usuario
	{
		//Para verificar si el usuario esta registrado
		public UUsuario existeUsuario(UUsuario nuevoUsuario)
		{
			using (var db = new Mapping())
			{
				return db.user.Where(x => x.Documento.Equals(nuevoUsuario.Documento)).FirstOrDefault();
			}
		}
		//public agregar usuario nuevo
		public void agregarUsuarioNuevo(UUsuario nuevoUsuario)
		{
			using (var db = new Mapping())
			{
				db.user.Add(nuevoUsuario);
				db.SaveChanges();
			}
		}
	}
}

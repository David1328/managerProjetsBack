using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Datos
{
	public class Proyecto
	{
		public UProyecto existeProyecto(UProyecto proyectoNuevo)
		{
			return new Mapping().uProyecto.Where(x => x.Nombre_proyecto.ToUpper().Equals(proyectoNuevo.Nombre_proyecto.ToUpper())).FirstOrDefault();
		}
		public void agregarNuevoProyecto(UProyecto proyectoNuevo)
		{
			using (var db = new Mapping())
			{
				db.uProyecto.Add(proyectoNuevo);
				db.SaveChanges();
			}
		}
		public List<UProyecto> obtenerProyectos()
		{
			using (var db = new Mapping())
			{
				List<UProyecto> listaProyecto = (from p in db.uProyecto
												 join u in db.user on p.Usuario_id equals u.Documento

												 select new
												 {
													 p,
													 u
												 }).ToList().Select(m => new UProyecto
												 {
													 Empresa_id = m.p.Empresa_id,
													 Id_proyecto = m.p.Id_proyecto,
													 Nombre_proyecto = m.p.Nombre_proyecto,
													 Nombre_usuario = m.u.Nombre,
													 Usuario_id = m.p.Usuario_id,
												 }).ToList();
				return listaProyecto;
			}
		}
	}
}

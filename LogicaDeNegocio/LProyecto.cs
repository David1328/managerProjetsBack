using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LProyecto
	{
		public string agregarProyecto(UProyecto proyectoNuevo)
		{
			if (new Proyecto().existeProyecto(proyectoNuevo) == null)
			{
				proyectoNuevo.Nombre_proyecto = proyectoNuevo.Nombre_proyecto.ToUpper();
				new Proyecto().agregarNuevoProyecto(proyectoNuevo);
				return "Registro De Proyecto Exitoso";
			}
			return null;
		}
		public List<UProyecto> obtenerProyectos()
		{
			return new Proyecto().obtenerProyectos();
		}
	}
}

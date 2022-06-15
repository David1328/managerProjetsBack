using Datos;
using System;
using System.Collections.Generic;
using Utilitarios;

namespace LogicaDeNegocio
{
	public class LHistoriaDeUsuario
	{
		public List<UHistoriaDeUsuario> obtenerHistorias()
		{
			return new HistoriaDeUsuario().obtenerHistoriasDeUsuario();
		}
	}
}

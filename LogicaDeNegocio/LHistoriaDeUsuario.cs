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

		public string agregarNuevaHistoria(UHistoriaDeUsuario nuevaHistoria)
		{
			DateTime id_ticket = DateTime.Now;
			string id_ticket_texto = id_ticket.ToString("u").Replace("Z", "").Replace(":","").Replace(" ","").Replace("-","");
			nuevaHistoria.NuevosTickets.Id_ticket = double.Parse(id_ticket_texto);
			new HistoriaDeUsuario().agregarHistorias(nuevaHistoria);
			return "Historia Agregada con exito";
		}
	}
}

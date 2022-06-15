using System.Data.Entity;
using Utilitarios;

public class Mapping : DbContext
{
	public Mapping() : base("name=Conexion")
	{

	}
	//Mapeo para empresa
	public DbSet<UEmpresa> uEmpresa { get; set; }
	//Mapeo para el usuario
	public DbSet<UUsuario> user { get; set; }
	//Mapeo para el pojo de proyecto
	public DbSet<UProyecto> uProyecto { get; set; }
	//Mapeo para el pojo de Historia de usuario
	public DbSet<UHistoriaDeUsuario> uHistoriaDeUsuario { get; set; }
	//Mapeo para el pojo de ticket
	public DbSet<UTicket> uTicket { get; set; }
	//Mapeo para el pojo de estado del ticket
	public DbSet<UEstado> uEstado { get; set; }
}
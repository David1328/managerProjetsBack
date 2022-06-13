using System.Data.Entity;
using Utilitarios;

public class Mapping : DbContext
{
	public Mapping() : base("name=Conexion")
	{

	}
	//Mapeo para empresa
	public DbSet<UEmpresa> uEmpresa { get; set; }
}
using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
	public class Repositorio : IRepositorio
	{
		public List<Pelicula> ObtenerPeliculas()
		{
			return new List<Pelicula>()
			{
				new Pelicula { Titulo = "Superman", FechaLanzamiento= new DateTime(2024,5,6)},
				new Pelicula { Titulo = "La monja", FechaLanzamiento= new DateTime(2024,7,25)},
				new Pelicula { Titulo = "Despertar", FechaLanzamiento= new DateTime(2023,12,6)}
			};
		}


	}
}

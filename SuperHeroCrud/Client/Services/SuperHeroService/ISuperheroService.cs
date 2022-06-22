using System;
using SuperHeroCrud.Shared;

namespace SuperHeroCrud.Client.Services.SuperHeroService
{
	public interface ISuperheroService
	{
		List<Superhero> Heroes { get; set; }
		List<Comic> Comics { get; set; }

		Task GetComics();
		Task GetSuperHeroes();
		Task<Superhero> GetSingleHero(int id);
	}
}


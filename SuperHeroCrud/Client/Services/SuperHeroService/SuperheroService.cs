using System;
using System.Net.Http.Json;

namespace SuperHeroCrud.Client.Services.SuperHeroService
{
    public class SuperheroService : ISuperheroService
    {
        private readonly HttpClient http;

        public SuperheroService(HttpClient http)
        {
            this.http = http;
        }

        public List<Superhero> Heroes { get; set; } = new List<Superhero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();

        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public Task<Superhero> GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetSuperHeroes()
        {
            //possibly wrong capitalisation
            var result = await this.http.GetFromJsonAsync<List<Superhero>>("api/superhero");
            if (result != null)
                Heroes = result;

        }
    }
}


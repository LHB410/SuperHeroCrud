 using System;
namespace SuperHeroCrud.Shared
{
	public class Superhero
	{
		public int Id { get; set; }
		public string firstName { get; set; } = string.Empty;
		public string lastName { get; set; } = string.Empty;
		public string heroName { get; set; } = string.Empty;
		public Comic? Comic { get; set; }
		public int ComicId { get; set; }
	}
		
}

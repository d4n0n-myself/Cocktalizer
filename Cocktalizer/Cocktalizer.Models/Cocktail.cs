using System.Collections.Generic;
using Cocktalizer.Models.Core;

namespace Cocktalizer.Models
{
	public class Cocktail : BaseEntity
	{
		public string Name { get; set; }
		public string PrepareMethod { get; set; }
		public List<Ingridient> Decorations { get; set; }
		public List<Ingridient> Components { get; set; }
	}
}
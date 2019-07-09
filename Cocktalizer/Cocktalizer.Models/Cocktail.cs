using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cocktalizer.Models.Core;

namespace Cocktalizer.Models
{
	public class Cocktail : BaseEntity
	{
		public string Name { get; set; }
		public string PrepareMethod { get; set; }
		[NotMapped] public List<Ingridient> Decorations { get; set; }
		[NotMapped] public List<Ingridient> Components { get; set; }
	}
}
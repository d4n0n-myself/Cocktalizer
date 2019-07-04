using Cocktalizer.Models.Core;

namespace Cocktalizer.Models
{
	public class Ingridient : BaseEntity
	{
		public Cocktail Cocktail { get; set; }
		public Product Product { get; set; }
		public double MeasurementValue { get; set; }
		public bool Decoration { get; set; }
	}
}
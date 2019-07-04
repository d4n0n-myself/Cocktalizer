namespace Cocktalizer.Models
{
	public class Ingridient
	{
		public Cocktail Cocktail { get; set; }
		public Product Product { get; set; }
		public double MeasurementValue { get; set; }
	}
}
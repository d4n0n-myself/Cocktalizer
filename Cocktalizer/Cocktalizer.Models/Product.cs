using System.Globalization;
using Cocktalizer.Models.Enums;

namespace Cocktalizer.Models
{
	public class Product
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public MeasurmentType Measurment { get; set; }

		public override string ToString()
		{
			return string.Join(' ',
				Name,
				Category,
				Price.ToString(CultureInfo.InvariantCulture),
				Measurment.ToString());
		}
	}
}
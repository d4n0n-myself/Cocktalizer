using Cocktalizer.Models.Core;
using Cocktalizer.Models.Enums;

namespace Cocktalizer.Models
{
	public class Product: BaseEntity
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public MeasurmentType Measurment { get; set; }

		public override string ToString()
		{
			return string.Join(' ',
				$"{nameof(Name)}: {Name}",
				$"{nameof(Category)}: {Category}",
				$"{nameof(Price)}: {Price}",
				$"{nameof(Measurment)}: {Measurment}");
		}
	}
}
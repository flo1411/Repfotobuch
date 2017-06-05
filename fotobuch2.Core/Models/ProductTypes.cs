using System;
namespace fotobuch2.Core.Models
{
	public class ProductType
	{
		public string title { get; set; }
		public int id { get; set; }
		public double price { get; set; }
		public string imageName { get; set; }

        public string DisplayPrice 
        {
            get
            {
                if(Math.Abs(price) < 0.001)
                {
                    return "Kostenlos mit Abo";
                }
                return $"{price} EUR mit Abo";
            }
        }

		public ProductType()
		{
		}
	}
}

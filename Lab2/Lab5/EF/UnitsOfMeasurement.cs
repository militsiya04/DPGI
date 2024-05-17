using System.Collections.Generic;

#nullable disable

namespace Lab5.EF
{
    public partial class UnitsOfMeasurement
    {
        public UnitsOfMeasurement()
        {
            Products = new HashSet<Product>();
        }

        public int UnitCode { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

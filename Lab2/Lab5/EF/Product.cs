#nullable disable

namespace Lab5.EF
{
    public partial class Product
    {
        public string Article { get; set; }
        public int? UnitCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual UnitsOfMeasurement UnitCodeNavigation { get; set; }
    }
}

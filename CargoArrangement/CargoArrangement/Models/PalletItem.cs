using System.Windows.Media;

namespace CargoArrangement.Models
{
    public class PalletItem
    {
        public int ID { get; set; }
        public string OrderNumber { get; set; }
        public string ClientName { get; set; }
        public string PartName { get; set; }
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Quantity { get; set; }
        public Color Color { get; set; }
        internal RootItem Fit { get; set; }
        public int PackageType { get; set; }
        public int PlacesNumber { get; set; }
    }
}
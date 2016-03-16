namespace CargoArrangement
{
    internal class RootItem
    {
        public int ContainerNumber { get; internal set; }
        public int Depth { get; set; }
        public RootItem Down { get; internal set; }
        public RootItem Right { get; internal set; }
        public bool Used { get; internal set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
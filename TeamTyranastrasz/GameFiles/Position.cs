namespace RpgGame
{
    public struct Position
    {
        public Position(int x = 0, int y = 0, int sizeX = 0, int sizeY = 0) : this()
        {
            this.X = x;
            this.Y = y;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int SizeX { get; set; }

        public int SizeY { get; set; }
    }
}

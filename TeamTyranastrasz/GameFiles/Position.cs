namespace RpgGame
{
    public struct Position
    {
        public Position(int x = 0, int y = 0) : this()

        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}

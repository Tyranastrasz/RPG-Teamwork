namespace RpgGame
{
    public abstract class Unit : GameObject
    {
        protected Unit(string name) : base(name)
        {
        }

        public Position Position { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}

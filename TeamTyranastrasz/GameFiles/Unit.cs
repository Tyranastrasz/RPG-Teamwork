namespace RpgGame
{
    public abstract class Unit : GameObject
    {
        protected Unit(string name) : base(name)
        {
        }

        public int Hp { get; set; }
        public int DefensePoints { get; set; }
        public int AttackPoints { get; set; }
        public Location Location { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

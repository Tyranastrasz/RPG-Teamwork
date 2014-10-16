namespace RpgGame
{
    public abstract class Unit : GameObject
    {
        protected Unit(string name) : base(name)
        {
        }

        public abstract int HitPoints { get; set; }
        public abstract int DefensePoints { get; set; }
        public abstract int AttackPoints { get; set; }
        public Position Position { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

using GameObject.Interfaces;

namespace GameObject.Items
{
    public abstract class Item : GameObject, IStats
    {
        protected Item(string name) : base(name)
        {
        }

        public int Price { get; set; }
        public int LevelRestriction { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public int Experience { get; set; }
        public int Cash { get; set; }
        public int LevelRequirement { get; set; }
    }
}

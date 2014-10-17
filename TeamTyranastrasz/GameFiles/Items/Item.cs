using System.ComponentModel;

namespace RpgGame.Items
{
    public abstract class Item : GameObject, IItem
    {
        protected Item(string name, int price, int defencePoints = 0, int attackPoints = 0, int hitPoints = 0, int str = 0, int dex = 0, int vit = 0, int intl = 0, int level = 0, string description = null)
            : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.LevelRequirement = level;
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.HitPoints = hitPoints;
            this.Price = price;
            this.Description = description;
        }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        public int Intelligence { get; set; }

        public int AttackPoints { get; protected set; }
        
        public int DefencePoints { get; protected set; }

        public int HitPoints { get; protected set; }

        public int LevelRequirement { get; set; }

        public int Price { get; set; }

        public string Description { get; protected set; }
    }
}

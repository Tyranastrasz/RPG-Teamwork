using RpgGame.Interfaces;
using System;

namespace RpgGame.Items
{
    public abstract class Item : GameObject, IItem
    {
        private int strength;
        private int dexterity;
        private int vitality;
        private int intelligence;
        private int price;

        protected Item(string name, int price, Pictures picture, int defencePoints = 0, int attackPoints = 0, int hitPoints = 0, int str = 0, int dex = 0, int vit = 0, int intl = 0, int level = 0, string description = null)
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
            this.Picture = picture;
        }

        public int Strength { 
            get { return this.strength; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.strength = value;
            }
        }

        public int Dexterity {
            get { return this.dexterity; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.strength = value;
            }
        }

        public int Vitality {
            get { return this.vitality; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.strength = value;
            }
        }

        public int Intelligence
        {
            get { return this.intelligence; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.strength = value;
            }
        }

        public int AttackPoints { get; protected set; }
        
        public int DefencePoints { get; protected set; }

        public int HitPoints { get; protected set; }

        public int LevelRequirement { get; set; }

        public int Price {
            get { return this.price; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.strength = value;
            }
        }

        public string Description { get; protected set; }

        public bool IsConsumable { get; set; }

        public Pictures Picture { get; set; }
    }
}

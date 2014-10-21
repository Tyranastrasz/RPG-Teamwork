namespace RpgGame.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RpgGame.Interfaces;
    using RpgGame.Items;
    using System.Windows.Forms;
    

    public abstract class Player : Unit, IMovable, ITeleportable, IUsable, ITrade, ICharacter
    {
        public readonly int StrengthModifier;
        public readonly int DexterityModifier;
        public readonly int VitalityModifier;
        public readonly int IntelligenceModifier;

        private Position position;

        protected Player(string name, int str, int dex, int vit, int intl, int strengthModifier, int dexterityModifier, int vitalityModifier, int intelligenceModifier) : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.StrengthModifier = strengthModifier;
            this.DexterityModifier = dexterityModifier;
            this.VitalityModifier = vitalityModifier;
            this.IntelligenceModifier = intelligenceModifier;
            CalculateAttackPoints();
            CalculateDefencePoints();
            CalculateHitPoints();
            this.CurrentHitPoints = this.MaxHitPoints;
            this.Position = new Position();
            this.PicBox = new PictureBox();
            this.Level = 1;
        }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        public int Intelligence { get; set; }

        public int MaxHitPoints { get; set; }

        public int DefencePoints { get; set; }

        public int AttackPoints { get; set; }

        public int BonusDefencePoints { get; set; }

        public int BonusAttackPoints { get; set; }

        public int Experience { get; set; }

        public PictureBox PicBox { get; set; }

        public int Cash { get; set; }

        public int Range { get; set; }

        public int Level { get; set; }

        public List<Item> Inventory { get; set; }

        public List<Item> Equiped { get; set; }

        private int CalculateAttackPoints()
        {
            this.AttackPoints = this.BonusAttackPoints + (this.Strength * this.StrengthModifier) + (this.Intelligence * this.IntelligenceModifier);
            return this.AttackPoints;
        }

        private int CalculateDefencePoints()
        {
            this.DefencePoints = this.BonusDefencePoints + this.Dexterity * this.DexterityModifier;
            return this.DefencePoints;
        }

        private int CalculateHitPoints()
        {
            this.MaxHitPoints = this.Vitality * this.VitalityModifier;
            return this.MaxHitPoints;
        }

        public virtual int Attack()
        {
            int damage = CalculateAttackPoints();
            if (this.Equiped != null)
            {
                damage += this.Equiped.Sum(item => item.AttackPoints);
            }
            return damage;
        }

        public virtual int Defend()
        {
            int defence = CalculateDefencePoints();
            if (this.Equiped != null)
            {
                defence += this.Equiped.Sum(item => item.DefencePoints);
            }
            return defence;
        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public void Teleport()
        {
            throw new NotImplementedException();
        }

        // The next couple of methods probably should implement an event - click over an item
        public void Consume(Item item)
        {
            if (item.IsConsumable)
            {
                this.MaxHitPoints += item.HitPoints;
                this.RemoveFromInventory(item);
            }
        }

        public void Equip(Item item)
        {
            foreach (var equipedItem in Equiped)
            {
                if (equipedItem.GetType() == item.GetType())
                {
                    throw new Exception("You cannot have two items from the same type");
                }
            }

            this.Equiped.Add(item);
        }

        public void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 10)
            {
                this.Inventory.Add(item);
            }
        }

        public void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }

        public void Sell(Item item)
        {
            this.Cash += item.Price;
            this.RemoveFromInventory(item);
        }

        public void Buy(Item item)
        {
            if (this.Cash >= item.Price)
            {
                this.AddToInventory(item);
            }
        }

        public int CalculateSkillStats(string type)
        {
            switch (type)
            {
                case "low":
                    return this.Level * 1;
                case "medium":
                    return (int)((double)this.Level * 1.5);
                case "heavy":
                    return this.Level * 2;
                default:
                    return 0;
            }
        }

        public abstract void CastBuff(string type);

        public abstract void ClearBuff(string type);

        public override string ToString()
        {
            return "Att: " + this.Attack()
                    + "Def: " + this.Defend()
                    + "Hp: " + this.CurrentHitPoints;
        }
    }
}

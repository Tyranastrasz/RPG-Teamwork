namespace RpgGame.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RpgGame.Interfaces;

    public abstract class Player : Unit, ITrade, ICharacter
    {
        public readonly int StrengthModifier;
        public readonly int DexterityModifier;
        public readonly int VitalityModifier;
        public readonly int IntelligenceModifier;

        private int strength;
        private int dexterity;
        private int vitality;
        private int intelligence;
        private int maxHitPoints;
        private int cash;
        private int experience;
        private int level;

        protected Player(string name, int str, int dex, int vit, int intl, int strengthModifier, int dexterityModifier, int vitalityModifier, int intelligenceModifier, List<IItem> baseItems) 
            : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.StrengthModifier = strengthModifier;
            this.DexterityModifier = dexterityModifier;
            this.VitalityModifier = vitalityModifier;
            this.IntelligenceModifier = intelligenceModifier;
            this.Position = new Position();
            this.Level = 1;
            this.Cash = 500;
            this.Inventory = new List<IItem>();
            this.Equiped = new List<IItem>();
            InitialItemEquip(baseItems);
            CalculateAttackPoints();
            CalculateDefencePoints();
            CalculateHitPoints();
            this.CurrentHitPoints = this.MaxHitPoints;
        }

        protected Player(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints, int experience, int cash, int level, List<IItem> inventory, List<IItem> equiped, Position position, int strengthModifier, int dexterityModifier, int vitalityModifier, int intelligenceModifier)
            : base(name)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Vitality = vitality;
            this.Intelligence = intelligence;
            this.MaxHitPoints = maxHitPoints;
            this.CurrentHitPoints = this.MaxHitPoints;
            this.Experience = experience;
            this.Cash = cash;
            this.Level = level;
            CloneInventory(inventory);
            CloneEquipedItems(equiped);
            this.Position = position;
            this.StrengthModifier = strengthModifier;
            this.DexterityModifier = dexterityModifier;
            this.VitalityModifier = vitalityModifier;
            this.IntelligenceModifier = intelligenceModifier;
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

                this.dexterity = value;
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

                this.vitality = value;
            }
        }

        public int Intelligence {
            get { return this.intelligence; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.intelligence = value;
            }
        }

        public int MaxHitPoints {
            get { return this.maxHitPoints; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.maxHitPoints = value;
            }
        }

        public int DefencePoints { get; set; }

        public int AttackPoints { get; set; }

        public int BonusDefencePoints { get; set; }

        public int BonusAttackPoints { get; set; }

        public int Experience {
            get { return this.experience; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.experience = value;
            }
        }

        public int Cash {
            get { return this.cash; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.cash = value;
            }
        }

        public int Range { get; set; }

        public int Level {
            get { return this.level; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("This value can not be negative!");
                }

                this.level = value;
            }
        }

        public List<IItem> Inventory { get; set; }

        public List<IItem> Equiped { get; set; }

        private void InitialItemEquip(List<IItem> baseItems)
        {
            for (int i = 0; i < baseItems.Count(); i++)
            {
                this.Equip(baseItems[i], i, true);
            }
        }

        private void CloneInventory(List<IItem> inventory)
        {
            if (inventory != null)
            {
                foreach (var item in inventory)
                {
                    this.Inventory.Add(item);
                }
            }
        }

        private void CloneEquipedItems(List<IItem> equiped)
        {
            if (equiped != null)
            {
                foreach (var item in equiped)
                {
                    this.Equiped.Add(item);
                }
            }
        }

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

        public int CalculateHitPoints()
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

        public void Consume(IItem item)
        {
            if (item.IsConsumable)
            {
                this.MaxHitPoints += item.HitPoints;
                this.RemoveFromInventory(item);
            }
        }

        public void Equip(IItem item, int id, bool isNew = false)
        {
            if (this.Equiped != null)
            {
                if (item.LevelRequirement <= this.Level)
                {
                    if (isNew)
                    {
                        this.Equiped.Add(item);
                    }
                    else
                    {
                        this.Equiped[id] = item;
                    }

                    this.Strength += item.Strength;
                    this.Intelligence += item.Intelligence;
                    this.Dexterity += item.Dexterity;
                    this.Vitality += item.Vitality;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new NullReferenceException("Fatal Error!");
            }
            
        }

        public void UnEquip(IItem item)
        {
            this.Strength -= item.Strength;
            this.Intelligence -= item.Intelligence;
            this.Dexterity -= item.Dexterity;
            this.Vitality -= item.Vitality;
        }

        public void AddToInventory(IItem item)
        {
            if (this.Inventory != null && this.Inventory.Count < 10)
            {
                this.Inventory.Add(item);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void RemoveFromInventory(IItem item)
        {
            this.Inventory.Remove(item);
        }

        public void Sell(IItem item)
        {
            this.Cash += item.Price / 2;
            this.RemoveFromInventory(item);
        }

        public void Buy(IItem item)
        {
            if (this.Cash >= item.Price)
            {
                this.Cash -= item.Price;
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

        public int CalculateExperience(int lvl)
        {
            double xp = 100;

            for (int i = 2; i <= lvl; i++)
            {
                xp += xp * 0.5;
            }

            return (int)xp;
        }
    }
}

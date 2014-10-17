
using System.Runtime.Remoting.Messaging;

namespace RpgGame.Player
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using RpgGame.Interfaces;
    using RpgGame.Items;

    public abstract class Player : Unit, IAttack, IDefend, IMovable, ITeleportable, IUsable, ITrade, ICharacter
    {
        //private int Level = 1;

        public readonly int StrengthModifier;
        public readonly int DexterityModifier;
        public readonly int VitalityModifier;
        public readonly int IntelligenceModifier;

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
        }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        public int Intelligence { get; set; }

        public int HitPoints { get; set; }

        public int DefencePoints { get; set; }

        public int AttackPoints { get; set; }

        public int Experience { get; set; }

        public int Cash { get; set; }

        //public int Level { get; set; }
        public IList<Item> Inventory { get; set; }

        public List<Item> Equiped { get; set; }

        private int CalculateAttackPoints()
        {
            this.AttackPoints = (this.Strength * this.StrengthModifier) + (this.Intelligence * this.IntelligenceModifier);
            return this.AttackPoints;
        }

        public int CalculateDefencePoints()
        {
            this.DefencePoints = this.Dexterity * this.DexterityModifier;
            return this.DefencePoints;
        }

        public int CalculateHitPoints()
        {
            this.HitPoints = this.Vitality * this.VitalityModifier;
            return this.HitPoints;
        }

        public virtual void Attack()
        {
            int damage = CalculateAttackPoints();
            damage += this.Equiped.Sum(item => item.DefencePoints);

        }

        public virtual void Defend()
        {
            int defence = CalculateDefencePoints(); 
            defence += this.Equiped.Sum(item => item.DefencePoints);
        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public void Teleport()
        {
            throw new NotImplementedException();
        }

        public void Consume()
        {
            throw new NotImplementedException();
        }

        public void Equip()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public void Buy()
        {
            throw new NotImplementedException();
        }
    }
}

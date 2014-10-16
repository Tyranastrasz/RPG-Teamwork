namespace RpgGame.Player
{
    using System;
    using System.Collections.Generic;
    using RpgGame.Interfaces;
    using RpgGame.Items;

    public abstract class Player : Unit, IAttack, IDefend, IMovable, ITeleportable, IUsable, ITrade, ICharacter
    {
        //private int Level = 1;
        protected int attackPoints;
        protected int defensePoints;
        protected int hitPoints;


        protected Player(string name, int str, int dex, int vit, int intl, int strengthModifier, int dexterityModifier, int vitalityModifier, int intelligenceModifier) : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.AttackPoints = (this.Strength * strengthModifier) + (this.Intelligence * intelligenceModifier);
            this.DefensePoints = this.Dexterity * dexterityModifier;
            this.HitPoints = this.Vitality*vitalityModifier;
        }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        public int Intelligence { get; set; }

        public override int HitPoints { get; set; }

        public override int DefensePoints { get; set; }

        public override int AttackPoints { get; set; }

        public int Experience { get; set; }

        public int Cash { get; set; }

        //public int Level { get; set; }
        public IList<Item> Inventory { get; set; }

        public IList<Item> Equiped { get; set; }

        public virtual void Attack()
        {
            throw new NotImplementedException();
        }

        public virtual void Defend()
        {
            throw new NotImplementedException();
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

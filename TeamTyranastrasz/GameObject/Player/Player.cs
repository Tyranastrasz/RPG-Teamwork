using GameObject.Interfaces;
using GameObject.Items;

namespace GameObject.Player
{
    using System;
    using System.Collections.Generic;

    public abstract class Player : Unit, IAttack, IDefend, IMovable, ITeleportable, IUsable, ITrade, IStats
    {
        //private int Level = 1;

        protected Player(string name) : base(name)
        {
        }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
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

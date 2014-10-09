using GameObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.Enemies
{
    public abstract class Enemy : Unit, IAttack
    {
        protected Enemy(string name) : base(name) // ??? enemies should't have names, just classes
        {
        }
        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}

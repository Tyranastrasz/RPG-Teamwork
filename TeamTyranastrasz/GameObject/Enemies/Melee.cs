namespace GameObject.Enemies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Melee : Enemy
    {
        protected Melee(string name) : base(name)
        {
        }
    }
}

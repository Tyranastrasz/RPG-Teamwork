namespace GameObject.Enemies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Boss : Enemy
    {
        protected Boss(string name) : base(name)
        {
        }
    }
}

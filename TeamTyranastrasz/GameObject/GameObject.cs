namespace GameObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameObject
    {
        protected GameObject(string name)
        {
        }
        public string Name { get; set; }
        // image?
    }
}

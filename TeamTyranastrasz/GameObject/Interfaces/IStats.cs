namespace GameObject.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStats
    {
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Vitality { get; set; }
        int Intelligence { get; set; }
        int Experience { get; set; }
        int Cash { get; set; }
    }
}

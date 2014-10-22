using System.Collections.Generic;
using RpgGame.Items;

namespace RpgGame.Interfaces
{
    public interface ICharacter : IUnit, IUsable
    {
        string Name { get; }

        int Strength { get; }

        int Dexterity { get; }

        int Vitality { get; }

        int Intelligence { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int BonusAttackPoints { get; set; }

        int BonusDefencePoints { get; set; }

        int MaxHitPoints { get; }

        int Experience { get; set; }

        int Cash { get; }

        int Range { get; }

        int Level { get; }

        List<IItem> Inventory { get; set; }

        List<IItem> Equiped { get; set; }

        void Sell(IItem item);

        void Buy(IItem item);

        Position Position { get; }

        int CalculateSkillStats(string type);

        void CastBuff(string type);
        
        void ClearBuff(string type);
    }
}

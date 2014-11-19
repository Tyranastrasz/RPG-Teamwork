namespace RpgGame.Interfaces
{
    using System.Collections.Generic;

    public interface ICharacter : IUnit, IUsable
    {
        string Name { get; set; }

        int Strength { get; set; }

        int Dexterity { get; set; }

        int Vitality { get; set; }

        int Intelligence { get; set; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int BonusAttackPoints { get; set; }

        int BonusDefencePoints { get; set; }

        int MaxHitPoints { get; }

        int Experience { get; set; }

        int Cash { get; set; }

        int Level { get; set; }

        IList<IItem> Inventory { get; set; }

        IList<IItem> Equiped { get; set; }

        void Sell(IItem item);

        void Buy(IItem item);

        Position Position { get; }

        int CalculateSkillStats(string type);

        void CastBuff(string type);
        
        void ClearBuff(string type);

        int CalculateExperience(int level);

        int CalculateHitPoints();
    }
}

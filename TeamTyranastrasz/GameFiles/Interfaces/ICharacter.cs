namespace RpgGame.Interfaces
{
    public interface ICharacter : IAttack
    {
        string Name { get; }

        int Strength { get; }

        int Dexterity { get; }

        int Vitality { get; }

        int Intelligence { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int MaxHitPoints { get; }

        int CurrentHitPoints { get; }

        int Experience { get; }

        int Cash { get; }

        int Range { get; }

        int Level { get; }

        Position Position { get; }
    }
}

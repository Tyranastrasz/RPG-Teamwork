namespace RpgGame.Interfaces
{
    public interface ICharacter : IUnit
    {
        string Name { get; }

        int Strength { get; }

        int Dexterity { get; }

        int Vitality { get; }

        int Intelligence { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int MaxHitPoints { get; }

        int Experience { get; }

        int Cash { get; }

        int Range { get; }

        int Level { get; }

        Position Position { get; }
    }
}

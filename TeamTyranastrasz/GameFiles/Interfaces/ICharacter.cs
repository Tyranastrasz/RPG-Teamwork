namespace RpgGame.Interfaces
{
    public interface ICharacter
    {
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

        Position Position { get; }
    }
}

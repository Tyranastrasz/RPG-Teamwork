namespace RpgGame.Interfaces
{
    public interface ICharacter
    {
        int Strength { get; }
        int Dexterity { get; }
        int Vitality { get; }
        int Intelligence { get; }
        int Experience { get; }
        int Cash { get; }
    }
}

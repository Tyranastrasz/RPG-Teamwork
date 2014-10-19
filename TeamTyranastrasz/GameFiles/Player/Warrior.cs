namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public const int StartingStrength = 4;
        public const int StartingDexterity = 3;
        public const int StartingVitality = 10;
        public const int StartingIntelligence = 2;
        
        public const int StrengthModifier = 2;
        public const int DexterityModifier = 2;
        public const int VitalityModifier = 3;
        public const int IntelligenceModifier = 1;

        private Position position;

        public Warrior(string name)
            : base(name, StartingStrength, StartingDexterity, StartingVitality, StartingIntelligence, StrengthModifier, DexterityModifier, VitalityModifier, IntelligenceModifier)
        {
        }

    }
}

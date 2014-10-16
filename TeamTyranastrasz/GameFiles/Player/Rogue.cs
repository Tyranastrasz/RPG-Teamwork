namespace RpgGame.Player
{
    public class Rogue : Player
    {
        public const int RogueStartingStrength = 10;
        public const int RogueStartingDexterity = 2;
        public const int RogueStartingVitality = 10;
        public const int RogueStartingIntelligence = 5;

        public const int RogueStrengthModifier = 3;
        public const int RogueDexterityModifier = 1;
        public const int RogueVitalityModifier = 1;
        public const int RogueIntelligenceModifier = 2;

        private Position position;

        public Rogue(string name)
            : base(name, RogueStartingStrength, RogueStartingDexterity, RogueStartingVitality, RogueStartingIntelligence, RogueStrengthModifier, RogueDexterityModifier, RogueVitalityModifier, RogueIntelligenceModifier)
        {
        }
    }
}

namespace RpgGame.Player
{
    public class Mage : Player
    {
        public const int MageStartingStrength = 1;
        public const int MageStartingDexterity = 3;
        public const int MageStartingVitality = 5;
        public const int MageStartingIntelligence = 10;

        public const int MageStrengthModifier = 1;
        public const int MageDexterityModifier = 1;
        public const int MageVitalityModifier = 2;
        public const int MageIntelligenceModifier = 3;

        private Position position;

        public Mage(string name)
            : base(name, MageStartingStrength, MageStartingDexterity, MageStartingVitality, MageStartingIntelligence, MageStrengthModifier, MageDexterityModifier, MageVitalityModifier, MageIntelligenceModifier)
        {
        }

    }
}

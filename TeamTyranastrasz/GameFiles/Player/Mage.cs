namespace RpgGame.Player
{
    public class Mage : Player
    {
        public const int startingStrength = 1;
        public const int startingDexterity = 3;
        public const int startingVitality = 5;
        public const int startingIntelligence = 10;

        public const int strengthModifier = 1;
        public const int dexterityModifier = 1;
        public const int vitalityModifier = 2;
        public const int intelligenceModifier = 3;

        private Position position;

        public Mage(string name)
            : base(name, startingStrength, startingDexterity, startingVitality, startingIntelligence, strengthModifier, dexterityModifier, vitalityModifier, intelligenceModifier)
        {
            //this.X = x;
            //this.Y = y;
        }

    }
}

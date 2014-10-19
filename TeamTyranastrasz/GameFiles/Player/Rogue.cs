namespace RpgGame.Player
{
    public class Rogue : Player
    {
        public const int startingStrength = 10;
        public const int startingDexterity = 2;
        public const int startingVitality = 10;
        public const int startingIntelligence = 5;

        public const int strengthModifier = 3;
        public const int dexterityModifier = 1;
        public const int vitalityModifier = 1;
        public const int intelligenceModifier = 2;

        private Position position;

        public Rogue(string name, Position position)
            : base(name, startingStrength, startingDexterity, startingVitality, startingIntelligence, strengthModifier, dexterityModifier, vitalityModifier, intelligenceModifier)
        {
            //this.X = x;
            //this.Y = y;
        }
    }
}

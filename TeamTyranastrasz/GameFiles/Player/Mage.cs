namespace RpgGame.Player
{
    public class Mage : Player
    {
        public const int strength = 4;
        public const int strengthModifier = 2;
        public const int dexterity = 3;
        public const int dexterityModifier = 2;
        public const int vitality = 10;
        public const int vitalityModifier = 3;
        public const int intelligence = 2;
        public const int intelligenceModifier = 1;

        public Mage(string name)
            : base(name, strength, dexterity, vitality, intelligence, strengthModifier, dexterityModifier, vitalityModifier, intelligenceModifier)
        {
            //this.X = x;
            //this.Y = y;
        }
    }
}

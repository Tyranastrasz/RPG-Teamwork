namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public const int strength = 4;
        public const int strengthModifier = 2;
        public const int dexterity = 3;
        public const int dexterityModifier = 2;
        public const int vitality = 10;
        public const int vitalityModifier = 3;
        public const int intelligence = 2;
        public const int intelligenceModifier = 1;

        private Position position;

        public Warrior(string name)
            : base(name, strength, dexterity, vitality, intelligence, strengthModifier, dexterityModifier, vitalityModifier, intelligenceModifier)
        {
            //this.X = x;
            //this.Y = y;
        }

        public override int HitPoints
        {
            get { return base.hitPoints; }
            set { this.hitPoints = vitality * vitalityModifier; }
        }

        public override int DefensePoints
        {
            get { return base.defensePoints; }
            set { this.defensePoints = dexterity * dexterityModifier; }
        }

        public override int AttackPoints
        {
            get { return base.attackPoints; }
            set
            {
                this.attackPoints = (this.Strength * strengthModifier) + (this.Intelligence * intelligenceModifier);
            }
        }
    }
}

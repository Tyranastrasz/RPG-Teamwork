namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public const int WarriorStartingStrength = 4;
        public const int WarriorStartingDexterity = 3;
        public const int WarriorStartingVitality = 10;
        public const int WarriorStartingIntelligence = 2;
        
        public const int WarriorStrengthModifier = 2;
        public const int WarriorDexterityModifier = 2;
        public const int WarriorVitalityModifier = 3;
        public const int WarriorIntelligenceModifier = 1;

        private Position position;

        public Warrior(string name)
            : base(name, WarriorStartingStrength, WarriorStartingDexterity, WarriorStartingVitality, WarriorStartingIntelligence, WarriorStrengthModifier, WarriorDexterityModifier, WarriorVitalityModifier, WarriorIntelligenceModifier)
        {
        }
    }
}

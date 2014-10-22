namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public const int WarriorStartingStrength = 5;
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

        public override void CastBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    this.Strength += (int)((double)this.Strength * 0.1);
                    break;
                case "defence":
                    this.Dexterity += (int)((double)this.Dexterity * 0.05);
                    break;
                case "health":
                    int vitality = (int)((double)this.Vitality * 0.2);
                    int addHitPoints = vitality * this.VitalityModifier;
                    if (addHitPoints + this.CurrentHitPoints > this.MaxHitPoints)
                    {
                        this.CurrentHitPoints = this.MaxHitPoints;
                    }
                    else
                    {
                        this.CurrentHitPoints += addHitPoints;
                    }
                    break;
            }
        }

        public override void ClearBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    this.Strength -= (int)((double)this.Strength * 0.1);
                    break;
                case "defence":
                    this.Dexterity -= (int)((double)this.Dexterity * 0.05);
                    break;
                case "health":
                    this.Vitality -= (int)((double)this.Vitality * 0.2);
                    break;
            }
        }
    }
}

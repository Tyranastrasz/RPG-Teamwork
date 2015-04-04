namespace RpgGame.Player
{
    using System.Collections.Generic;

    using Interfaces;

    using Items;

    public class Warrior : Player
    {
        private const CharacterType WarriorCharacterType = RpgGame.CharacterType.Warrior;

        public const int WarriorStartingStrength = 5;
        public const int WarriorStartingDexterity = 2;
        public const int WarriorStartingVitality = 8;
        public const int WarriorStartingIntelligence = 2;

        public const int WarriorStrengthModifier = 2;
        public const int WarriorDexterityModifier = 2;
        public const int WarriorVitalityModifier = 3;
        public const int WarriorIntelligenceModifier = 1;

        public static readonly List<IItem> WarriorBaseItems = new List<IItem>
        {
            // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
            new Helmet("Mail Helmet", 25, Pictures.WarriorHelmet, 2, 0, 3, 0, 1, 1, 0, 1,
                "Metal helmet is the best helmet;"),
            new Weapon("Old Dulled Axe", 5, Pictures.BasickSword, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."),
            new Chainmail("Battle Armor", 25, Pictures.WarriorChainmail, 2, 0, 3, 0, 1, 1, 0, 1,
                "It will save your life."),
            new Gloves("Steel Gloves", 20, Pictures.WarriorsGloves, 1, 0, 2, 0, 1, 2, 0, 1,
                "Very heavy - only for strong warriors."),
            new Boots("Heavy Boots", 10, Pictures.WarriorBoots, 1, 0, 2, 0, 0, 1, 0, 1, "Make you very slow.")
        };

        public Warrior(string name)
            : base(
                name, Warrior.WarriorStartingStrength, Warrior.WarriorStartingDexterity, Warrior.WarriorStartingVitality,
                Warrior.WarriorStartingIntelligence, Warrior.WarriorStrengthModifier, Warrior.WarriorDexterityModifier,
                Warrior.WarriorVitalityModifier, Warrior.WarriorIntelligenceModifier, Warrior.WarriorBaseItems,
                Warrior.WarriorCharacterType)
        {
        }

        public Warrior(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints,
                       int experience, int cash, int level, Position position)
            : base(
                name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, position,
                Warrior.WarriorStrengthModifier, Warrior.WarriorDexterityModifier, Warrior.WarriorVitalityModifier,
                Warrior.WarriorIntelligenceModifier, Warrior.WarriorCharacterType)
        {
        }

        public override void CastBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    Strength += (int) (Strength*0.1);
                    break;
                case "defence":
                    Dexterity += (int) (Dexterity*0.05);
                    break;
                case "health":
                    int vitality = (int) (Vitality*0.2);
                    int addHitPoints = vitality*VitalityModifier;
                    if (addHitPoints + CurrentHitPoints > MaxHitPoints)
                    {
                        CurrentHitPoints = MaxHitPoints;
                    }
                    else
                    {
                        CurrentHitPoints += addHitPoints;
                    }
                    break;
            }
        }

        public override void ClearBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    Strength -= (int) (Strength*0.09);
                    break;
                case "defence":
                    Dexterity -= (int) (Dexterity*0.0525);
                    break;
            }
        }
    }
}
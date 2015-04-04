namespace RpgGame.Player
{
    using System.Collections.Generic;

    using Interfaces;

    using Items;

    public class Mage : Player
    {
        public const CharacterType MageCharacterType = RpgGame.CharacterType.Mage;

        public const int MageStartingStrength = 3;
        public const int MageStartingDexterity = 5;
        public const int MageStartingVitality = 7;
        public const int MageStartingIntelligence = 10;

        public const int MageStrengthModifier = 1;
        public const int MageDexterityModifier = 1;
        public const int MageVitalityModifier = 2;
        public const int MageIntelligenceModifier = 3;

        public static readonly List<IItem> MageBaseItems = new List<IItem>
        {
            // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
            new Helmet("Apprentice Hat", 10, Pictures.MageHelmet, 1, 0, 3, 0, 1, 1, 0, 1,
                "Basic wizard hat - for new wizards."),
            new Weapon("Wooden Staff", 15, Pictures.BasickStaff, 0, 5, 0, 0, 0, 0, 3, 1, "Basic wizard weapon."),
            new Chainmail("Battle Robe", 25, Pictures.MageChainmail, 2, 0, 4, 0, 2, 2, 0, 1,
                "Sturdy and durable - good for adventurers."),
            new Gloves("Encated Gloves", 15, Pictures.MageGloves, 2, 0, 1, 0, 0, 1, 2, 1,
                "Have small enchantment for better magic casting."),
            new Boots("Simple Boots", 10, Pictures.MageBoots, 1, 0, 1, 0, 0, 2, 0, 1,
                "Simple and cheap, good for walking.")
        };

        public Mage(string name)
            : base(
                name, Mage.MageStartingStrength, Mage.MageStartingDexterity, Mage.MageStartingVitality,
                Mage.MageStartingIntelligence, Mage.MageStrengthModifier, Mage.MageDexterityModifier,
                Mage.MageVitalityModifier, Mage.MageIntelligenceModifier, Mage.MageBaseItems, Mage.MageCharacterType)
        {
        }

        public Mage(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints,
                    int experience, int cash, int level, Position position)
            : base(
                name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, position,
                Mage.MageStrengthModifier, Mage.MageDexterityModifier, Mage.MageVitalityModifier,
                Mage.MageIntelligenceModifier, Mage.MageCharacterType)
        {
        }

        public override void CastBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    Intelligence += (int) (Intelligence*0.1);
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
                    Intelligence -= (int) (Intelligence*0.09);
                    break;
                case "defence":
                    Dexterity -= (int) (Dexterity*0.0525);
                    break;
            }
        }
    }
}
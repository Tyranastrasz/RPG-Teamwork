namespace RpgGame.Player
{
    using System.Collections.Generic;

    using Interfaces;

    using Items;

    public class Rogue : Player
    {
        private const CharacterType RogueCharacterType = RpgGame.CharacterType.Rogue;

        public const int RogueStartingStrength = 10;
        public const int RogueStartingDexterity = 4;
        public const int RogueStartingVitality = 10;
        public const int RogueStartingIntelligence = 5;

        public const int RogueStrengthModifier = 3;
        public const int RogueDexterityModifier = 1;
        public const int RogueVitalityModifier = 1;
        public const int RogueIntelligenceModifier = 2;

        public static readonly List<IItem> RogueBaseItems = new List<IItem>
        {
            // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
            new Helmet("Leather Cap", 15, Pictures.RogueHelmet, 2, 0, 3, 0, 2, 1, 0, 1, "Light, with medium defence."),
            new Weapon("Rusty Dagger", 10, Pictures.BasickDager, 0, 6, 0, 2, 0, 0, 1, 1,
                "The rust helps - infects targets."),
            new Chainmail("Armored Jacket", 20, Pictures.RogueChainmail, 3, 0, 3, 0, 2, 1, 0, 1, "Light armored."),
            new Gloves("Dark-Skin Gloves", 20, Pictures.RogueGLoves, 2, 0, 2, 0, 1, 2, 0, 1,
                "Good gloves, for skillful hands."),
            new Boots("Speed boots", 10, Pictures.RogueBoots, 1, 0, 2, 0, 0, 1, 0, 1, "Light and very fast.")
        };

        public Rogue(string name)
            : base(
                name, Rogue.RogueStartingStrength, Rogue.RogueStartingDexterity, Rogue.RogueStartingVitality,
                Rogue.RogueStartingIntelligence, Rogue.RogueStrengthModifier, Rogue.RogueDexterityModifier,
                Rogue.RogueVitalityModifier, Rogue.RogueIntelligenceModifier, Rogue.RogueBaseItems, Rogue.RogueCharacterType)
        {
        }

        public Rogue(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints,
                     int experience, int cash, int level, Position position)
            : base(
                name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, position,
                Rogue.RogueStrengthModifier, Rogue.RogueDexterityModifier,
                Rogue.RogueVitalityModifier, Rogue.RogueIntelligenceModifier, Rogue.RogueCharacterType)
        {
        }


        public override void CastBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    Strength += (int) (Strength*0.07);
                    Intelligence += (int) (Intelligence*0.03);
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
                    Strength -= (int) (Strength*0.0695);
                    Intelligence -= (int) (Intelligence*0.03);
                    break;
                case "defence":
                    Dexterity -= (int) (Dexterity*0.0525);
                    break;
            }
        }
    }
}
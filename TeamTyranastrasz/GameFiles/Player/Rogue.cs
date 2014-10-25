namespace RpgGame.Player
{
    using RpgGame.Items;
    using RpgGame.Interfaces;
    using System.Collections.Generic;

    public class Rogue : Player
    {
        public const int RogueStartingStrength = 10;
        public const int RogueStartingDexterity = 4;
        public const int RogueStartingVitality = 10;
        public const int RogueStartingIntelligence = 5;

        public const int RogueStrengthModifier = 3;
        public const int RogueDexterityModifier = 1;
        public const int RogueVitalityModifier = 1;
        public const int RogueIntelligenceModifier = 2;

        public static readonly List<IItem> RogueBaseItems = new List<IItem>()
        {
            // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
            new Helmet( "Leather Cap", 15, Pictures.RogueHelmet, 2, 0, 3, 0, 2, 1, 0, 1, "Light, with medium defence."),
            new Weapon("Rusty Dagger", 10, Pictures.BasickDager, 0, 6, 0, 2, 0, 0, 1, 1, "The rust helps - infects targets."),
            new Chainmail("Armored Jacket", 20, Pictures.RogueChainmail, 3, 0, 3, 0, 2, 1, 0, 1, "Light armored."),
            new Gloves("Dark-Skin Gloves", 20, Pictures.RogueGLoves, 2, 0, 2, 0, 1, 2, 0, 1, "Good gloves, for skillful hands."),
            new Boots("Speed boots", 10, Pictures.RogueBoots, 1, 0, 2, 0, 0, 1, 0, 1, "Light and very fast."),
        };

        public Rogue(string name)
            : base(name, RogueStartingStrength, RogueStartingDexterity, RogueStartingVitality, RogueStartingIntelligence, RogueStrengthModifier, RogueDexterityModifier, RogueVitalityModifier, RogueIntelligenceModifier, RogueBaseItems)
        {
        }

        public Rogue(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints, int experience, int cash, int level, Position position)
            : base(name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, position, RogueStrengthModifier, RogueDexterityModifier, RogueVitalityModifier, RogueIntelligenceModifier)
        {
        }


        public override void CastBuff(string type)
        {
            switch (type)
            {
                case "attack":
                    this.Strength += (int)((double)this.Strength * 0.07);
                    this.Intelligence += (int)((double)this.Intelligence * 0.03);
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
                    this.Strength -= (int)((double)this.Strength * 0.0695);
                    this.Intelligence -= (int)((double)this.Intelligence * 0.03);
                    break;
                case "defence":
                    this.Dexterity -= (int)((double)this.Dexterity * 0.0525);
                    break;
            }
        }
    }
}

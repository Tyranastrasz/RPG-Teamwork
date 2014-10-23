using RpgGame.Interfaces;

namespace RpgGame.Player
{
    using RpgGame.Items;
    using System.Collections.Generic;

    public class Rogue : Player
    {
        public const int RogueStartingStrength = 10;
        public const int RogueStartingDexterity = 2;
        public const int RogueStartingVitality = 10;
        public const int RogueStartingIntelligence = 5;

        public const int RogueStrengthModifier = 3;
        public const int RogueDexterityModifier = 1;
        public const int RogueVitalityModifier = 1;
        public const int RogueIntelligenceModifier = 2;

        public static readonly List<IItem> RogueBaseItems = new List<IItem>()
        {
            new Helmet("Iron Sword", 5, Pictures.BasickSword, 1, 5, 0, 0, 0, 20, 0, 1, "Basic battle equipment."),
            new Weapon("Iron Sword", 5, Pictures.BasickSword, 1, 5, 0, 0, 0, 20, 0, 1, "Basic battle equipment."),
            new Chainmail("Iron Sword", 5, Pictures.BasickSword, 1, 5, 0, 0, 0, 20, 0, 1, "Basic battle equipment."),
            new Gloves("Iron Sword", 5, Pictures.BasickSword, 1, 5, 0, 0, 0, 20, 0, 1, "Basic battle equipment."),
            new Boots("Iron Sword", 5, Pictures.BasickSword, 1, 5, 0, 0, 0, 20, 0, 1, "Basic battle equipment."),
        };

        public Rogue(string name)
            : base(name, RogueStartingStrength, RogueStartingDexterity, RogueStartingVitality, RogueStartingIntelligence, RogueStrengthModifier, RogueDexterityModifier, RogueVitalityModifier, RogueIntelligenceModifier, RogueBaseItems)
        {
        }

        public Rogue(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints, int experience, int cash, int level, List<IItem> inventory, List<IItem> equiped, Position position)
            : base(name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, inventory, equiped, position, RogueStrengthModifier, RogueDexterityModifier, RogueVitalityModifier, RogueIntelligenceModifier)
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
                    this.Strength -= (int)((double)this.Strength * 0.07);
                    this.Intelligence -= (int)((double)this.Intelligence * 0.03);
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

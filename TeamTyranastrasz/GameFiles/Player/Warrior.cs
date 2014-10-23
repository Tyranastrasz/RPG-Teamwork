using RpgGame.Interfaces;
using RpgGame.Items;
using System.Collections.Generic;

namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public const int WarriorStartingStrength = 5;
        public const int WarriorStartingDexterity = 2;
        public const int WarriorStartingVitality = 8;
        public const int WarriorStartingIntelligence = 2;

        public const int WarriorStrengthModifier = 2;
        public const int WarriorDexterityModifier = 2;
        public const int WarriorVitalityModifier = 3;
        public const int WarriorIntelligenceModifier = 1;

        public static readonly List<IItem> WarriorBaseItems = new List<IItem>()
        {
            // name, price, picture, def, attk, hit, str, dex, vit, int, lvl, desc
            new Helmet("Mail Helmet", 25, Pictures.WarriorHelmet, 2, 0, 3, 0, 1, 1, 0, 1, "Metal helmet is the best helmet;"),
            new Weapon("Old Dulled Axe", 5, Pictures.BasickSword, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."),
            new Chainmail("Battle Aromor", 25, Pictures.WarriorChainmail, 2, 0, 3, 0, 1, 1, 0, 1, "It will save your life."),
            new Gloves("Steel Gloves", 20, Pictures.WarriorsGloves, 1, 0, 2, 0, 1, 2, 0, 1, "Very heavy - olny for strong warriors."),
            new Boots("Heavy Boots", 10, Pictures.WarriorBoots, 1, 0, 2, 0, 0, 1, 0, 1, "Make you very slow."),
        };

        public Warrior(string name)
            : base(name, WarriorStartingStrength, WarriorStartingDexterity, WarriorStartingVitality, WarriorStartingIntelligence, WarriorStrengthModifier, WarriorDexterityModifier, WarriorVitalityModifier, WarriorIntelligenceModifier, WarriorBaseItems)
        {
        }

        public Warrior(string name, int strength, int dexterity, int vitality, int intelligence, int maxHitPoints, int experience, int cash, int level, List<IItem> inventory, List<IItem> equiped, Position position)
            : base(name, strength, dexterity, vitality, intelligence, maxHitPoints, experience, cash, level, inventory, equiped, position, WarriorStrengthModifier, WarriorDexterityModifier, WarriorVitalityModifier, WarriorIntelligenceModifier)
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

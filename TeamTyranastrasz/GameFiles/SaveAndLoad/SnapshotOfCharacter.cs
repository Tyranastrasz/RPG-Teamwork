using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgGame.Interfaces;
using RpgGame.Items;

namespace RpgGame.SaveAndLoad
{
    public struct SnapshotOfCharacter
    {
        private readonly string name;
        private readonly int strength;
        private readonly int dexterity;
        private readonly int vitality;
        private readonly int intelligence;
        private readonly int maxHitPoints;
        private readonly int experience;
        private readonly int cash;
        private readonly int level;
        private List<IItem> inventory;
        private List<IItem> equiped;
        private readonly Position position;

        public SnapshotOfCharacter(ICharacter currentPlayerState)
        {
            this.name = currentPlayerState.Name;
            this.strength = currentPlayerState.Strength;
            this.dexterity = currentPlayerState.Dexterity;
            this.vitality = currentPlayerState.Vitality;
            this.intelligence = currentPlayerState.Intelligence;
            this.maxHitPoints = currentPlayerState.MaxHitPoints;
            this.experience = currentPlayerState.Experience;
            this.cash = currentPlayerState.Cash;
            this.level = currentPlayerState.Level;
            this.inventory = new List<IItem>();
            this.equiped = new List<IItem>();
            this.position = currentPlayerState.Position;
            CloneEquipedItems(currentPlayerState);
            CloneEquipedItems(currentPlayerState);
        }

        private void CloneInventory(ICharacter currentPlayerState)
        {
            if (currentPlayerState.Inventory != null)
            {
                foreach (var item in currentPlayerState.Inventory)
                {
                    this.inventory.Add(item);
                }
            }
        }

        private void CloneEquipedItems(ICharacter currentPlayerState)
        {
            if (currentPlayerState.Equiped != null)
            {
                foreach (var item in currentPlayerState.Equiped)
                {
                    this.equiped.Add(item);
                }
            }
        }

        public string Name { get { return this.name; } }

        public int Strength { get { return this.strength; } }

        public int Dexterity { get { return this.dexterity; } }

        public int Vitality { get { return this.vitality; } }

        public int Intelligence { get { return this.intelligence; } }

        public int MaxHitPoints { get { return this.maxHitPoints; } }

        public int Experience { get { return this.experience; } }

        public int Cash { get { return this.cash; } }

        public int Level { get { return this.level; } }

        public List<IItem> Inventory { get { return this.inventory; } }

        public List<IItem> Equiped { get { return this.equiped; } }

        public Position Position { get { return this.position; } }
    }
}

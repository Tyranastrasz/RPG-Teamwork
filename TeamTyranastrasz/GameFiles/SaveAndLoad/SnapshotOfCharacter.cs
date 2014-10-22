namespace RpgGame.SaveAndLoad
{
    using System.Collections.Generic;
    using System.Linq;
    using RpgGame.Interfaces;

    public struct SnapshotOfCharacter
    {
        private string name;
        private int strength;
        private int dexterity;
        private int vitality;
        private int intelligence;
        private int maxHitPoints;
        private int experience;
        private int cash;
        private int level;
        private List<IItem> inventory;
        private List<IItem> equiped;
        private Position position;

        public SnapshotOfCharacter(ICharacter currentPlayerState)
            : this()
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
            CloneInventory(currentPlayerState);
            CloneEquipedItems(currentPlayerState);
        }

        public string Name
        {
            get { return this.name; } 

            set { this.name = value; }
        }

        public int Strength
        {
            get { return this.strength; } 

            set { this.strength = value; }
        }

        public int Dexterity
        {
            get { return this.dexterity; } 

            set { this.dexterity = value; }
        }

        public int Vitality
        {
            get { return this.vitality; } 

            set { this.vitality = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; } 
            set { this.intelligence = value; }
        }

        public int MaxHitPoints
        {
            get { return this.maxHitPoints; } 
            
            set { this.maxHitPoints = value; }
        }

        public int Experience
        {
            get { return this.experience; } 
            
            set { this.experience = value; }
        }

        public int Cash
        {
            get { return this.cash; } 

            set { this.cash = value; }
        }

        public int Level
        {
            get { return this.level; } 
            
            set { this.level = value; }
        }

        public List<IItem> Inventory
        {
            get { return this.inventory; } 
            
            set { this.inventory = value.ToList(); }
        }

        public List<IItem> Equiped
        {
            get { return this.equiped; }
            
            set { this.equiped = value.ToList(); }
        }

        public Position Position
        {
            get { return this.position; } 
            set { this.position = value; }
        }

        private int CheckPlayersInventory(ICharacter currentPlayerState)
        {
            int countItemsInInventory = 0;
            if (currentPlayerState.Inventory != null)
            {
                return countItemsInInventory += currentPlayerState.Inventory.Count;
            }
            else
            {
                return countItemsInInventory;
            }
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
    }
}

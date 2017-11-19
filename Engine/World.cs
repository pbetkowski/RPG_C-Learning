using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Monster> Monsters = new List<Monster>();

        //creating ID of objects in game

        public const int ItemTrainingSword = 1;

        public const int MonsterIDZombie = 1;

        public const int QuestIDTestQuest = 1;

        public const int LocationIDTrainingHall = 1;
        public const int LocationIDVillage = 2;


        public static void PopulateItems ()
        {
            Items.Add(new Weapon(ItemTrainingSword, "Training Sword", "Training Swords", 0, 3));
        }

        public static void PopulateMonsters()
        {
            Monster Zombie = new Monster(MonsterIDZombie, "Zombie", 2, 3, 2, 3, 4);
            Zombie.LootItems.Add(new LootItem(ItemByID(ItemTrainingSword), 1, true));  //adding loot to zombie

            Monsters.Add(Zombie);

        }

        public static void PopulateQuests()
        {
            Quest FirstQuest = new Quest(QuestIDTestQuest, "First quest", "ToUpdateLater", 12, 12);
            FirstQuest.QuestCompletionItems.Add(new QuestRewardItem(ItemByID(ItemTrainingSword), 1));
            FirstQuest.RewardItem = ItemByID(ItemTrainingSword);  //check

            Quests.Add(FirstQuest);
        }


        public static void PopulateLocations()
        {
            Location TrainingHall = new Location(LocationIDTrainingHall, "Training hall", "This is your home");
            Location Road = new Location(LocationIDVillage, "Road to village", "Follow north to reach a village");

            TrainingHall.LocationToNorth = Road;

            
            Locations.Add(TrainingHall);

        }


        //finding by id

        public static Item ItemByID (int id)
        {
            foreach(Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID (int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Location LocationByID (int id)
        {
            foreach(Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }

        public static Quest QuestByID (int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }





    }
}

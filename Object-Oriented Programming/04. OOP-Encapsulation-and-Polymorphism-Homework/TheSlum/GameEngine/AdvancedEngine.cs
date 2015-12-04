using System;
using System.Linq;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class AdvancedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItemToCharacter(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterType = inputParams[1];
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            string teamType = inputParams[5];
            Team team = (Team)Enum.Parse(typeof(Team), teamType);

            Character character = CharacterFactory.Create(characterType, id, x, y, team);

            this.characterList.Add(character);
        }

        protected void AddItemToCharacter(string[] inputParams)
        {
            string characterId = inputParams[1];
            Character character = this.characterList.First(c => c.Id == characterId);

            Item item = ItemFactory.Create(inputParams[2], inputParams[3]);

            character.AddToInventory(item);
        }
    }
}
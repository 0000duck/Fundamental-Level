namespace RPG.Characters
{
    using Weapons;

    public class Warrior : Character
    {
        private const string WarriorName = "Warrior";

        public Warrior(Weapon weapon)
            : base(weapon)
        {
            this.Name = WarriorName;
        }
    }
}

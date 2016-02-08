namespace RPG.Characters
{
    using Weapons;

    public class Mage : Character
    {
        private const string MageName = "Mage";

        public Mage(Weapon weapon)
            : base(weapon)
        {
            this.Name = MageName;
        }
    }
}

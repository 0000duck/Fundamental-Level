namespace DefiningClasses_Exercise
{
    public class DefiningClassesExerciseMain
    {
        public static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            Dog seconDog = new Dog("Bravo", "Husky");

            firstDog.Breed = "Doberman";

            firstDog.Bark();
            seconDog.Bark();
        }
    }
}
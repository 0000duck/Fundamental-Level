import Exceptions.OutOfEnergyException;

/**
 * Created by ivailojordanov on 10/31/15.
 */
public class Main {
    public static void main(String[] args) {
        GameCharacter goshoTheWarrior = new Warrior("Gosho");
        GameCharacter peshoTheMage = new Mage("Pesho");

        int roundCount = 0;
        while (true) {
            System.out.println("Round: " + ++roundCount);
            try {
                if (roundCount % 2 == 0) {
                    goshoTheWarrior.attack(peshoTheMage);
                    peshoTheMage.attack(goshoTheWarrior);
                } else {
                    peshoTheMage.attack(goshoTheWarrior);
                    goshoTheWarrior.attack(peshoTheMage);
                }
            } catch (OutOfEnergyException e) {
                System.out.println(e.getMessage());

                break;
            }

            System.out.println();
        }

        String winnerName = (peshoTheMage.getHealth() > goshoTheWarrior.getHealth()? peshoTheMage.getName(): goshoTheWarrior.getName());

        System.out.println("Winner is: " + winnerName);
    }
}

import java.util.Scanner;

/**
 * Created by ivailojordanov on 11/15/15.
 */
public class Problem1 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int numberOfPeople = Integer.parseInt(console.nextLine());

        int numberOfLines = Integer.parseInt(console.nextLine());
        int bedsCount = 0;
        int mealsCount = 0;

        for (int i = 0; i < numberOfLines; i++) {
            String line = console.nextLine();
            String[] inputArgs = line.split("\\s+");

            String input = inputArgs[0];
            int quantity = Integer.parseInt(inputArgs[1]);
            String type = inputArgs[2];

            switch (input) {
                case "tents":
                    if (type.equals("normal")) {
                        bedsCount += (2 * quantity);
                    } else {
                        bedsCount += (3 * quantity);
                    }
                    break;
                case "rooms":
                    if (type.equals("single")) {
                        bedsCount += quantity;
                    }
                    if (type.equals("double")) {
                        bedsCount += (2 * quantity);
                    }
                    if (type.equals("triple")) {
                        bedsCount += (3 * quantity);
                    }
                    break;
                case "food":
                    if (type.equals("musaka")) {
                        mealsCount += (2 * quantity);
                    }
                    break;
            }
        }

        int bedsLeft = bedsCount - numberOfPeople;
        int mealsLeft = mealsCount - numberOfPeople;

        if (bedsLeft >= 0) {
            System.out.println("Everyone is happy and sleeping well. Beds left: " + bedsLeft);
        } else {
            System.out.println("Some people are freezing cold. Beds needed: " + Math.abs(bedsLeft));
        }

        if (mealsLeft >= 0) {
            System.out.println("Nobody left hungry. Meals left: " + mealsLeft);
        } else {
            System.out.println("People are starving. Meals needed: " + Math.abs(mealsLeft));
        }

    }
}

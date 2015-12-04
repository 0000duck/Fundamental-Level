import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/19/15.
 */
public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String firstString = console.next().trim();
        String secondString = console.next().trim();

        System.out.println(MultiplyCharacters(firstString, secondString));

    }

    private static int MultiplyCharacters(String firstString, String secondString) {
        int totalSum = 0;

        int max = firstString.length() > secondString.length() ? firstString.length() : secondString.length();
        int min = firstString.length() > secondString.length() ? secondString.length() : firstString.length();
        for (int i = 0; i < max; i++) {
            if (i < min) {
                totalSum += ((int) firstString.charAt(i) * (int) secondString.charAt(i));
            } else if (firstString.length() > secondString.length()) {
                totalSum += (int) firstString.charAt(i);
            } else if (secondString.length() > firstString.length()) {
                totalSum += (int) secondString.charAt(i);
            }
        }

        return totalSum;
    }
}

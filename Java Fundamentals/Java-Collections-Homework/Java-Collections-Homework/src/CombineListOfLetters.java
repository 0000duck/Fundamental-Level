import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CombineListOfLetters {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String firstInput = console.nextLine();
        String secondInput = console.nextLine();

        ArrayList<Character> input = new ArrayList<>();
        ArrayList<Character> output = new ArrayList<>();

        for (int i = 0; i < firstInput.length(); i++) {
            char currentChar = firstInput.charAt(i);
            if (currentChar != ' ') {
                input.add(currentChar);
            }
        }

        for (int i = 0; i < secondInput.length(); i++) {
            char currentChar = secondInput.charAt(i);
            if (currentChar != ' ' && !input.contains(currentChar)) {
                output.add(currentChar);
            }
        }

        output.addAll(0, input);
        for (Character character : output) {
            System.out.print(character + " ");
        }
    }
}
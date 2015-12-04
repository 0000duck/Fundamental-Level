import java.util.LinkedHashSet;
import java.util.Random;
import java.util.Scanner;
import java.util.Set;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int firstNum = console.nextInt();
        int secondNum = console.nextInt();

        int minimum = Math.min(firstNum, secondNum);
        int maximum = Math.max(secondNum, firstNum);

        Random rn = new Random();
        int range = maximum - minimum + 1;

        Set<Integer> generated = new LinkedHashSet<>();
        while (generated.size() < range) {
            int randomNum = rn.nextInt(range) + minimum;
            generated.add(randomNum);

        }
        generated.forEach(p -> System.out.println(p));
    }
}
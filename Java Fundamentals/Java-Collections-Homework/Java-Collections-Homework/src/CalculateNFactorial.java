import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CalculateNFactorial {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int factorial = console.nextInt();

        System.out.println(calculateFactorial(factorial));
    }

    private static int calculateFactorial(int number) {
        if (number == 1 || number == 0) {
            return 1;
        }
        return number * calculateFactorial(number - 1);
    }
}

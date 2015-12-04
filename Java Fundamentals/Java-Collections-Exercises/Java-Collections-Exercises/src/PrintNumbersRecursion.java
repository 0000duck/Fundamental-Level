import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/25/15.
 */
public class PrintNumbersRecursion {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        int n = Integer.parseInt(scn.nextLine());

        printRecursive(n);
    }

    private static void printRecursive(int n) {
        if (n < 1) {
            return;
        }

        printRecursive(n - 1);

        System.out.println(n);
    }
}

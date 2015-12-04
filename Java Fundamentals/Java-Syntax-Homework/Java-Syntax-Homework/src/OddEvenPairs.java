import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/19/15.
 */
public class OddEvenPairs {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String line = console.nextLine();
        String[] strs = line.trim().split("\\s+");
        int[] array = new int[strs.length];
        for (int i = 0; i < array.length; i++) {
            array[i] = Integer.parseInt(strs[i]);
        }

        if (array.length % 2 == 1) {
            System.out.println("Invalid length");
        } else {
            for (int i = 1; i < array.length; i += 2) {
                if (array[i - 1] % 2 == 0 && array[i] % 2 == 0) {
                    System.out.printf("%1$d, %2$d -> both are even\n", array[i - 1], array[i]);
                } else if (array[i - 1] % 2 == 1 && array[i] % 2 == 1) {
                    System.out.printf("%1$d, %2$d -> both are odd\n", array[i - 1], array[i]);
                } else {
                    System.out.printf("%1$d, %2$d -> different\n", array[i - 1], array[i]);
                }
            }
        }
    }
}

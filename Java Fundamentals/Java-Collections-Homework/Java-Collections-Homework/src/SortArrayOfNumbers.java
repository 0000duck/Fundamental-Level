import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = console.nextInt();
        int[] array = new int[n];

        for (int i = 0; i < array.length; i++) {
            array[i] = console.nextInt();
        }

        Arrays.sort(array);

        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i] + " ");
        }
    }
}

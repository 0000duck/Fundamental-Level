import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] array = console.nextLine().split(" ");

        int i;
        for (i = 0; i < array.length - 1; i++) {
            if (array[i].equals(array[i + 1])) {
                System.out.print(array[i] + " ");
            } else {
                System.out.println(array[i]);
            }
        }
        System.out.println(array[i]);
    }
}

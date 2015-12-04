import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] array = console.nextLine().split(" ");

        List<String> longestSequence = new ArrayList<>();
        int max = 1;

        for (int i = 0; i < array.length - 1; i++) {
            if (array[i].equals(array[i + 1])) {
                max++;
                if (max > longestSequence.size()) {
                    longestSequence.clear();
                    for (int j = 1; j <= max; j++) {
                        longestSequence.add(array[i]);
                    }
                }
            } else {
                max = 1;
            }
        }

        if (longestSequence.size() == 0) longestSequence.add(array[0]);
        for (String s : longestSequence) {
            System.out.print(s + " ");
        }
    }
}

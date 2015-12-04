import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String input = console.nextLine().toLowerCase();
        String word = console.nextLine().toLowerCase();

        int occurrences = 0;
        int searchIndex = 0;
        int findIndex;

        while ((findIndex = input.indexOf(word, searchIndex)) >= 0) {
            occurrences++;
            searchIndex = findIndex + 1;
        }

        System.out.println(occurrences);
    }
}

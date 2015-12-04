import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        List<String> input = Arrays.asList(console.nextLine().toLowerCase().split("\\W+"));
        String word = console.nextLine();

        System.out.println(Collections.frequency(input, word));
    }
}

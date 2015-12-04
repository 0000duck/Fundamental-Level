import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        List<String> input = Arrays.asList(console.nextLine().toLowerCase().split("\\W+"));

        System.out.println(String.join(" ", input.stream().distinct().sorted().collect(Collectors.toList())));
    }
}

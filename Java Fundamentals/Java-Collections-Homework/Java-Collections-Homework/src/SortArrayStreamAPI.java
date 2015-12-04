import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class SortArrayStreamAPI {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        List<String> input = Arrays.asList(console.nextLine().split(" "));
        String sortingOrder = console.nextLine();
        boolean isAscending = sortingOrder.equals("Ascending");

        if (isAscending) {
            input.stream()
                    .map(s -> Integer.parseInt(s))
                    .sorted((x, y) -> x.compareTo(y))
                    .forEach(num -> System.out.print(num + " "));
        } else {
            input.stream()
                    .map(s -> Integer.parseInt(s))
                    .sorted((x, y) -> y.compareTo(x))
                    .forEach(num -> System.out.print(num + " "));
        }
    }
}

import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.stream.Stream;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class ImplementRecursiveBinarySearch {
    static List<Integer> hayStack;

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int needle = console.nextInt();
        console.nextLine();

        hayStack = Stream.of(console.nextLine().split(" "))
                .map(num -> Integer.parseInt(num))
                .sorted()
                .collect(Collectors.toList());

        int needleIndex = binarySearch(needle, 0, hayStack.size() - 1);
        System.out.println(needleIndex);

    }

    private static int binarySearch(int needle, int start, int end) {

        if (end < start) {
            return -1;
        }

        int middle = (start + end) / 2;

        if (hayStack.get(middle) < needle) {
            return binarySearch(needle, middle + 1, end);
        }

        if (hayStack.get(middle) > needle) {
            return binarySearch(needle, start, middle - 1);
        }

        return middle;
    }
}

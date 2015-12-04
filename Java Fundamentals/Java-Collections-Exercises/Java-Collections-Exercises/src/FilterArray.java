import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by ivailojordanov on 10/25/15.
 */
public class FilterArray {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        String[] elements = scn.nextLine().split(" ");

        List<Integer> numbers = Arrays.stream(elements).filter(FilterArray::isNumber).map(Integer::parseInt).collect(Collectors.toList());

        int sum = numbers.stream().mapToInt(Integer::intValue).sum();
        int sumAnotherWay = numbers.stream().collect(Collectors.summingInt(Integer::intValue));
        int sumReduce = numbers.stream().reduce((x, y) -> x + y).get();

        System.out.println(sum);
        System.out.println(sumAnotherWay);
        System.out.println(sumReduce);
    }

    public static boolean isNumber(String str) {
        for (char c : str.toCharArray()) {
            if (!Character.isDigit(c)) {
                return false;
            }
        }
        return true;
    }
}

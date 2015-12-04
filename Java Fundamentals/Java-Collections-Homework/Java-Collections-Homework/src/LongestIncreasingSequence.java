import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] inputArray = console.nextLine().split(" ");
        List<Integer> input = new ArrayList<>();
        List<Integer> output = new ArrayList<>();
        List<Integer> longestSequence = new ArrayList<>();

        for (String s : inputArray) {
            input.add(Integer.parseInt(s));
        }

        while (input.size() > 0) {
            output.add(input.get(0));
            input.remove(0);

            for (int i = 0; i < input.size(); i++) {
                if (input.get(i) > output.get(output.size() - 1)) {
                    output.add(input.get(i));
                    input.remove(input.get(i));
                    i--;
                } else break;
            }

            if (longestSequence.size() < output.size()) {
                longestSequence.clear();
                longestSequence.addAll(0, output);
            }
            System.out.println(output.toString().replaceAll("[\\[\\], ]", " ").trim());
            output.clear();
        }

        System.out.println("Longest: " + longestSequence.toString().replaceAll("[\\[\\], ]", " ").trim());
    }
}

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by ivailojordanov on 11/15/15.
 */
public class Problem2 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Pattern pattern = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?([0-9]+)L");

        String line = console.nextLine();
        int totalLiters = 0;

        while (!line.equals("OK KoftiShans")) {
            Matcher matcher = pattern.matcher(line);

            while (matcher.find()) {
                String guest = matcher.group(1);
                String drink = matcher.group(2).toLowerCase();
                int quantity = Integer.parseInt(matcher.group(3));

                totalLiters += quantity;

                System.out.printf("%s brought %d liters of %s!\n", guest, quantity, drink);
            }

            line = console.nextLine();
        }
        System.out.printf("%.3f softuni liters", totalLiters / 1000.0);
    }
}

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by ivailojordanov on 10/19/15.
 */
public class StartsEndsWithCapital {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Pattern pattern = Pattern.compile("(\\b[A-Z][a-zA-Z]*[A-Z]\\b)");

        String line = console.nextLine();
        Matcher matcher = pattern.matcher(line);

        while (matcher.find()) {
            System.out.printf("%1$s ", matcher.group());
        }
    }
}

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class ExtractEmails {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String input = console.nextLine();
        Pattern pattern = Pattern.compile("[a-zA-Z0-9]+[a-zA-Z0-9\\\\.\\\\-_]*[a-zA-Z0-9]+@[a-zA-Z0-9]+[a-zA-Z0-9\\\\.]+[a-zA-Z0-9]+");
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()) {
            System.out.println(matcher.group());
        }
    }
}

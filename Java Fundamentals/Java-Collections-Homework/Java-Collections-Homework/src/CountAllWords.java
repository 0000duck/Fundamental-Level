import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CountAllWords {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        System.out.println(console.nextLine().split("\\W+").length);
    }
}

import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = Integer.parseInt(console.nextLine());
        double b = Double.parseDouble(console.nextLine());
        double c = Double.parseDouble(console.nextLine());

        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|", a, String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0'), b, c);
    }
}

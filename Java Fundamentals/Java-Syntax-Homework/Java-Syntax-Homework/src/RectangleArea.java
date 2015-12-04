import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class RectangleArea {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = console.nextInt();
        int b = console.nextInt();

        System.out.println(RectArea(a, b));
    }

    private static int RectArea(int a, int b) {
        return a * b;
    }
}

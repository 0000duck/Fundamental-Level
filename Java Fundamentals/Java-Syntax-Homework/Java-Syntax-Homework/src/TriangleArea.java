import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class TriangleArea {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int a = console.nextInt();
        int b = console.nextInt();
        console.nextLine();
        int c = console.nextInt();
        int d = console.nextInt();
        console.nextLine();
        int e = console.nextInt();
        int f = console.nextInt();

        System.out.println(TriagArea(a, b, c, d, e, f));
    }

    private static int TriagArea(int a, int b, int c, int d, int e, int f) {
        return Math.abs((((a - e) * (d - f)) - ((c - e) * (b - f))) / 2);
    }
}

import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class ConvertBaseSevenDecimal {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] number = console.nextLine().split("");
        System.out.println(BaseSeven(number));
    }

    private static int BaseSeven(String[] number) {
        int result = 0;
        for (int i = number.length - 1, n = 0; i >= 0; i--, n++) {
            result += (Integer.parseInt(number[n]) * Math.pow(7, i));
        }
        return result;
    }
}

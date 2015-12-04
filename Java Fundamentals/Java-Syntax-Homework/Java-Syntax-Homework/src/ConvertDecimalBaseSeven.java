import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class ConvertDecimalBaseSeven {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int number = Integer.parseInt(console.nextLine());
        System.out.println(BaseSeven(number));
    }

    private static int BaseSeven(int number) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= 4; i++) {
            sb.insert(0, Integer.toString(number % 7));
            number = number / 7;
        }
        return Integer.parseInt(sb.toString());
    }
}

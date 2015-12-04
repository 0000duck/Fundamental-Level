import java.util.HashMap;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/19/15.
 */
public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String firstWord = console.next().trim();
        String secondWord = console.next().trim();

        System.out.println(ExchangeableWords(firstWord, secondWord));
    }

    private static boolean ExchangeableWords(String firstWord, String secondWord) {
        HashMap<Character, Character> map = new HashMap<>();

        for (int i = 0; i < firstWord.length(); i++) {
            char a = firstWord.charAt(i);
            char b = secondWord.charAt(i);

            if (map.containsKey(a)) {
                if (map.get(a) != b) {
                    return false;
                }
            } else {
                if (map.containsValue(b)) {
                    return false;
                }

                map.put(a, b);
            }
        }

        return true;
    }
}

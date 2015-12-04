import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/26/15.
 */
public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] input = console.nextLine().trim().split(" ");
        Map<String, Integer> map = new LinkedHashMap<>();

        for (int i = 0; i < input.length; i++) {
            String cardFace = input[i].substring(0, input[i].length() - 1);
            if (!map.containsKey(cardFace)) {
                map.put(cardFace, 0);
            }

            map.put(cardFace, map.get(cardFace) + 1);
        }

        for (Map.Entry<String, Integer> card : map.entrySet()) {
            double percentage = ((double) card.getValue() / input.length) * 100;
            System.out.printf("%s -> %.2f%%\n", card.getKey(), percentage);
        }
    }
}

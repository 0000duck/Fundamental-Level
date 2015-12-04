import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/19/15.
 */
public class GetFirstOddEvenElements {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] strs = console.nextLine().trim().split("\\s+");
        int[] array = new int[strs.length];
        for (int i = 0; i < array.length; i++) {
            array[i] = Integer.parseInt(strs[i]);
        }
        String[] secondLine = console.nextLine().split("\\s+");
        int n = Integer.parseInt(secondLine[1]);
        boolean isEven = secondLine[2].equals("even") ? true : false;
        if (isEven == true) {
            System.out.println(GetElements(array, n, isEven));
        } else {
            System.out.println(GetElements(array, n, isEven));
        }
    }

    private static String GetElements(int[] array, int n, boolean isEven) {
        List<Integer> list = new ArrayList<>();
        if (isEven == true) {
            for (int i = 0; i < array.length; i++) {
                if (array[i] % 2 == 0) {
                    list.add(array[i]);
                }
            }
        } else {
            for (int i = 0; i < array.length; i++) {
                if (array[i] % 2 == 1) {
                    list.add(array[i]);
                }
            }
        }
        String joined = "";
        for (int num : list) {
            joined += num + " ";
        }
        return joined;
    }
}

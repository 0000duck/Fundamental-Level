import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class SumLines {
    public static void main(String[] args) {
        File file = new File("resources/SumLines.txt");
        BufferedReader br;
        String line;

        try {
            br = new BufferedReader(new FileReader(file));

            while ((line = br.readLine()) != null) {
                char[] data = line.toCharArray();
                int sum = 0;

                for (int i = 0; i < data.length; i++)
                    sum += (int) data[i];

                System.out.println(sum);
            }
            br.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

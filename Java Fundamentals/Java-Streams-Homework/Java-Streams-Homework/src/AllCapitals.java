import java.io.*;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class AllCapitals {
    public static void main(String[] args) {
        File file = new File("resources/SumLines.txt");
        File outputFile = new File("output/AllCapitalsOutput.txt");
        BufferedReader br;
        String line;

        try {
            br = new BufferedReader(new FileReader(file));
            FileWriter fw = new FileWriter(outputFile, true);
            PrintWriter writer = new PrintWriter(fw, true);

            while ((line = br.readLine()) != null) {
                writer.println(line.toUpperCase());
            }
            fw.close();
            writer.close();
            br.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

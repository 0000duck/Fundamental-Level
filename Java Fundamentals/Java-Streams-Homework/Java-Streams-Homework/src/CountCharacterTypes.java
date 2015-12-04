import java.io.*;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class CountCharacterTypes {
    public static void main(String[] args) {
        File file = new File("resources/words.txt");
        File outputFile = new File("output/count-chars.txt");
        BufferedReader br;
        String line;

        try {
            br = new BufferedReader(new FileReader(file));
            FileWriter fw = new FileWriter(outputFile, true);
            PrintWriter writer = new PrintWriter(fw, true);

            while ((line = br.readLine()) != null) {
                char[] data = line.toCharArray();
                int vowels = 0;
                int consonants = 0;
                int punctuation = 0;

                for (int i = 0; i < data.length; i++) {
                    char c = data[i];
                    switch (c) {
                        case 'a':
                            vowels++;
                            break;
                        case 'e':
                            vowels++;
                            break;
                        case 'i':
                            vowels++;
                            break;
                        case 'o':
                            vowels++;
                            break;
                        case 'u':
                            vowels++;
                            break;
                        case '!':
                            punctuation++;
                            break;
                        case '.':
                            punctuation++;
                            break;
                        case ',':
                            punctuation++;
                            break;
                        case '?':
                            punctuation++;
                            break;
                        case ' ':
                            break;
                        default:
                            consonants++;
                            break;
                    }
                }

                writer.println("Vowels: " + vowels);
                writer.println("Consonants: " + consonants);
                writer.println("Punctuation: " + punctuation);
            }
            fw.close();
            writer.close();
            br.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

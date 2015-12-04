import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class CopyJPGFile {
    public static void main(String[] args) {
        File file = new File("resources/CopyJPGFile.jpeg");
        File outputFile = new File("output/my-copied-picture.jpeg");

        try {
            FileInputStream fis = new FileInputStream(file);
            FileOutputStream fos = new FileOutputStream(outputFile);

            try {
                int currentByte = fis.read();
                while (currentByte != -1) {
                    fos.write(currentByte);
                    currentByte = fis.read();
                }
            } catch (IOException exception) {
                System.err.println("IOException occurred!");
                exception.printStackTrace();
            } finally {
                fis.close();
                fos.close();
                System.out.println("Copied file!");
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}

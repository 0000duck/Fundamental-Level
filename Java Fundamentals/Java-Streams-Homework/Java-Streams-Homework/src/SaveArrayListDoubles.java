import java.io.*;
import java.util.ArrayList;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class SaveArrayListDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("resources/doubles.list"));
        ArrayList<Double> doubles = new ArrayList<>();

        doubles.add(3.6);
        doubles.add(4.6);
        doubles.add(5.6);
        doubles.add(6.6);

        oos.writeObject(doubles);
        oos.flush();
        ObjectInputStream ois = new ObjectInputStream(new FileInputStream("resources/doubles.list"));
        System.out.println(ois.readObject());
        ois.close();
    }
}

import java.io.*;

/**
 * Created by ivailojordanov on 10/21/15.
 */
public class ReadLogUsers {
    private static final String FILE_PATH = "resources/users.txt";
    private static final String SAVE_PATH = "total-time.txt";
    public static void main(String[] args) {
        File file = new File(FILE_PATH);
        File outputFile = new File(SAVE_PATH);
        BufferedReader reader = null;
        try {
            reader = new BufferedReader(new FileReader(file));
            String line = reader.readLine();
            FileWriter fw = new FileWriter(outputFile, true);
            PrintWriter writer = new PrintWriter(fw, true);

            while(line != null){
                String[] lineArgs = line.split(" ");
                String username = lineArgs[0];
                int totalMinutes = 0;
                int minute = 0;
                int hour = 0;
                int day = 0;
                for (int i = 1; i < lineArgs.length; i++) {
                    String[] loggedTime = lineArgs[i].split(":");
                    int hours = Integer.parseInt(loggedTime[0]);
                    int minutes = Integer.parseInt(loggedTime[1]);
                    totalMinutes += (hours * 60) + minutes;
                    minute += minutes;
                    hour += hours;
                    day += hours / 24;
                }

                String output = username + " " + totalMinutes;
                hour = hour + (minute / 60);
                minute = minute % 60;
                output += " (" + day + " days, " + hour + " hours, " + minute + " minutes" + ")";
                writer.println(output);
                line = reader.readLine();
            }

            writer.close();
            reader.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

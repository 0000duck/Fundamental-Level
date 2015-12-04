import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/18/15.
 */
public class CalculateExpression {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        double a = Double.parseDouble(console.nextLine());
        double b = Double.parseDouble(console.nextLine());
        double c = Double.parseDouble(console.nextLine());

        double FirstExpressionResult = FirstExpression(a, b, c);
        double SecondExpressionResult = SecondExpression(a, b, c);

        System.out.printf("F1 result: %.2f; ", FirstExpressionResult);
        System.out.printf("F2 result: %.2f; ", SecondExpressionResult);
        System.out.printf("Diff: %.2f", Math.abs((((a + b + c) / 3) - ((FirstExpressionResult + SecondExpressionResult) / 2))));
    }

    private static double FirstExpression(double a, double b, double c) {
        return Math.pow(((Math.pow(a, 2) + Math.pow(b, 2)) / (Math.pow(a, 2) - Math.pow(b, 2))), ((a + b + c) / Math.sqrt(c)));
    }

    private static double SecondExpression(double a, double b, double c) {
        return Math.pow((Math.pow(a, 2) + Math.pow(b, 2) - Math.pow(c, 3)), (a - b));
    }
}

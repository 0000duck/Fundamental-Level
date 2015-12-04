package com.company;

import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/17/15.
 */
public class GetAverage {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        double a = Double.parseDouble(console.nextLine());
        double b = Double.parseDouble(console.nextLine());
        double c = Double.parseDouble(console.nextLine());

        System.out.printf("%.2f", averageNumber(a, b, c));
    }
    public static double averageNumber(double a, double b, double c) {
        return (a + b + c) / 3;
    }
}

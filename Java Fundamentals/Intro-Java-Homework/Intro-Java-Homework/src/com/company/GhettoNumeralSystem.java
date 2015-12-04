package com.company;

import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/17/15.
 */
public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] input = console.nextLine().split("");
        String result = "";

        for (int i = 0; i < input.length; i++) {
            switch (input[i]) {
                case "0": result += "Gee";
                    break;
                case "1": result += "Bro";
                    break;
                case "2": result += "Zuz";
                    break;
                case "3": result += "Ma";
                    break;
                case "4": result += "Duh";
                    break;
                case "5": result += "Yo";
                    break;
                case "6": result += "Dis";
                    break;
                case "7": result += "Hood";
                    break;
                case "8": result += "Jam";
                    break;
                case "9": result += "Mack";
                    break;
                default: result += input[i];
                    break;
            }
        }

        System.out.println(result);
    }
}

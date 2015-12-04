package com.company;

import java.util.Scanner;

/**
 * Created by ivailojordanov on 10/17/15.
 */
public class SumNumbers1N {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());
        int sum = 0;

        for (int i = 0; i <= n; i++) {
            sum += i;
        }

        System.out.println(sum);
    }
}

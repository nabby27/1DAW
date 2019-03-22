/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package _149;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int max = 0;
        int numeroDeToros = 0;
        while (sc.hasNext()) {
            max = 0;
            numeroDeToros = sc.nextInt();
            for (int i = 1; i <= numeroDeToros; i++) {
                int toroNum = sc.nextInt();
                if (max < toroNum) {
                    max = toroNum;
                }
            }
            System.out.println(max);
        }
    }
    
}

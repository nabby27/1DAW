/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package _116;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String numString = sc.next();
        int num = Integer.parseInt(numString);
        for (int i = 0; i < num; i++) {
            System.out.println("Hola mundo.");
        }
    }
    
}

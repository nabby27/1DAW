/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio4;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio4 {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = 0;
        boolean bisiesto = false;
        
        System.out.println("Dime un número de un año:");
        num = sc.nextInt();
        
        bisiesto = num % 400 == 0||(num % 4 == 0 && num % 100 != 0) ? true : false;
        //bisiesto = comprobarBisiesto(num);
        if (bisiesto)
            System.out.println("El año introducido es bisiesto");
        else
            System.out.println("El año introducido no es bisiesto");
    }
    
//    private static boolean comprobarBisiesto(int num) {
//        boolean solve = false;
//        if (num % 400 == 0)
//            solve = true;
//        else if (num % 4 == 0 && num % 100 != 0)
//            solve = true;
//        return solve;
//    }
}


import java.util.Scanner;


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio03 {
    
    public static void main(String[] args) {
        
        int num1 = 0;
        int num2 = 0;
        int mayor = 0;
        Scanner keyboard = new Scanner(System.in);
       
        System.out.println("Dime el valor del número 1");
        num1 = keyboard.nextInt();
        System.out.println("Dime el valor del número 2");
        num2 = keyboard.nextInt();
        
        mayor  = mayor(num1, num2);
        System.out.println("El número más grande es: " + mayor);
    }
    
    private static int mayor(int a, int b) {
        if (a >= b) {
            return a;
        } else {
            return b;
        }
    }
    
}

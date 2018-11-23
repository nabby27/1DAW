
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
public class Ejercicio07 {
    
    static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        int num1 = 0;
        int num2 = 0;
        
        do {
            System.out.println("Dime un número no primo");
            num1 = sc.nextInt();
            System.out.println("Dime otro número no primo");
            num2 = sc.nextInt();
            
            if (primo(num1)) {
                System.out.println("El número 1 tiene que ser no primo");
            } else if (primo(num2)) {
                System.out.println("El número 2 tiene que ser no primo");
            } else {
                sumaDivisores(num1, num2);
            }
        } while (primo(num1) || primo(num2));
    }

    private static boolean primo(int num) {
        for (int i = 2; i < num; i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
    
    private static void sumaDivisores(int num1, int num2) {
        int suma = 0;
        for (int i = 2; i < num1; i++) {
            if (num1 % i == 0) {
                suma += i;
            }
        }
        for (int i = 2; i < num2; i++) {
            if (num2 % i == 0) {
                suma += i;
            }
        }
        System.out.println("La suma de los divisores de " + num1 + " y " + num2 + " es: " + suma);
    }
    
}

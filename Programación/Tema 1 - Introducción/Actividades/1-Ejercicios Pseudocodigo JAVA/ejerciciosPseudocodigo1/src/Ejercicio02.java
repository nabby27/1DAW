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
public class Ejercicio02 {
    
    public static void main(String[] args) {
        System.out.println("OPERACIONES");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el primer número:");
        float num1 = teclado.nextShort();
        System.out.print("Dime el segundo número:");
        float num2 = teclado.nextShort();
        
        System.out.println("La suma de " + num1 + " + " + num2 +" es: " + (num1 + num2));
        System.out.println("La resta de " + num1 + " - " + num2 +" es: " + (num1 - num2));
        System.out.println("La multiplicación de " + num1 + " * " + num2 +" es: " + (num1 * num2));
        System.out.println("La división de " + num1 + " / " + num2 +" es: " + (num1 / num2));
        System.out.println("El resto de " + num1 + " / " + num2 +" es: " + (num1 % num2));
    }
    
}

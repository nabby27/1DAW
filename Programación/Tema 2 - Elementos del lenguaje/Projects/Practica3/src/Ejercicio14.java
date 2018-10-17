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
public class Ejercicio14 {
    
    public static void main(String[] args) {
        
        float num1 = 0;
        float num2 = 0;
        float num3 = 0;
        float num4 = 0;
        float suma = 0;
        float mult = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número 1: ");
        num1 = teclado.nextFloat();
        System.out.print("Dime el número 2: ");
        num2 = teclado.nextFloat();
        System.out.print("Dime el número 3: ");
        num3 = teclado.nextFloat();
        System.out.print("Dime el número 4: ");
        num4 = teclado.nextFloat();
        
        System.out.println("La suma de " + num1 + " + " + num2 + " = " + (num1 + num2));
        System.out.println("La multiplicacion de " + num3 + " * " + num4 + " = " + (num3 * num4));
        
    }
    
}

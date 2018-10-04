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
public class Ejercicio01 {

    public static void main(String[] args) {
        System.out.println("¿Cual es más grande?");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número 1: ");
        int num1 = teclado.nextInt();
        System.out.print("Dime el número 2: ");
        int num2 = teclado.nextInt();
        System.out.print("Dime el número 3: ");
        int num3 = teclado.nextInt();
        
        if ((num1 >= num2) && (num1 >= num3))
            System.out.println("El número " + num1 + " es más grande");
        else if ((num2 > num1) && (num2 >= num3))
            System.out.println("El número " + num2 + " es más grande");
        else
            System.out.println("El número " + num3 + " es más grande");
    }
    
}

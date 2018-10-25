
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
public class Ejercicio04 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int opcion = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número: ");
            num = teclado.nextInt();
            if (num < 0 || num > 10)
                System.out.println("El número tiene que estar entre 0 y 10");
        } while (num < 0 || num > 10);
        
        System.out.println("¿Que quieres hacer?");
        System.out.println("1 - Comprobar si es primo");
        System.out.println("2 - Halla su factorial");
        System.out.println("3 - Imprimir su tabla de multiplicar");
        opcion = teclado.nextInt();
        
        switch (opcion) {
            case 1:
                primo(num);
                break;
            case 2:
                factorial(num);
                break;
            case 3:
                tabla(num);
                break;
        }
    }
    
    private static void primo(int num) {
        boolean primo = true;
        for (int x = 2; x < num; x++) {
            if (num % x == 0)
                primo = false;
        }
        if (primo)
            System.out.println("Es primo");
        else
            System.out.println("No es primo");
    }
    
    private static void factorial(int num) {
        int resultado = 1;
        for (int x = 1; x <= num; x++) {
            resultado = resultado * x;
        }
        System.out.println("El factorial de " + num + " es: " + resultado);
    }
    
    private static void tabla(int num) {
        System.out.println("TABLA DE MULTIPLICAR DEL " + num);
        for (int x = 0; x <= 10; x++) {
            System.out.println(num + " x " + x + " = " + (num*x) );
        }
    }
}

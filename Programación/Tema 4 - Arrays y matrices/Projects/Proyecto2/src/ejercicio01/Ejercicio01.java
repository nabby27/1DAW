package ejercicio01;


import java.util.ArrayList;
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
    
    private static int totalElementos = 15;
    
    public static void main(String[] args) {
        
        int vector[] = new int[totalElementos];
        int numero = 0;
        int index = 0;
        int suma = 0;
        Scanner sc = new Scanner(System.in);
        
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime un número: ");
            numero = sc.nextInt();
            vector[i] = numero;
        }
        System.out.print("vector: ");
        for (int i = 0; i < vector.length; i++) {
            if (i == 0)
                System.out.print("[" + vector[i] + ", ");
            else if (i == vector.length-1)
                System.out.print(vector[i] + "]");
            else
                System.out.print(vector[i] + ", ");
        }
        System.out.println("");
        System.out.println("Dime hasta que indice del array quieres que se sume: ");
        index = sc.nextInt();
        
        for (int i = 0; i <= index; i++) {
            suma += vector[i];
        }
        
        System.out.println("La suma es: " + suma);
    }
    
}

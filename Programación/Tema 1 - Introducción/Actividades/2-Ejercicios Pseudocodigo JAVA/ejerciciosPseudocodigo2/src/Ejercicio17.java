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
public class Ejercicio17 {
    
    public static void main(String[] args) {
        System.out.println("SUMA PARES MENORES DE 100");
        
        int suma = 0;
        
        for (int x = 0; x < 101; x += 2) {
            suma += x;
        }
        
        System.out.println("La suma de los numeros mpares menores de 100 es: " + suma);
    }
    
}

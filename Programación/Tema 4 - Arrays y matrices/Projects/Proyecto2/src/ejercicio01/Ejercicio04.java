/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio01;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio04 {
    
    public static void main(String[] args) {
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        int numero = 0;
        Scanner sc = new Scanner(System.in);
        
        for (int i = 0; i < 15; i++) {
            System.out.println("Dime el número " + (i+1));
            numero = sc.nextInt();                
            numeros.add(numero);
        }

        System.out.println("Los numeros son: " + numeros);
        System.out.print("Los numeros al reves son: ");
        for (int i = numeros.size()-1; i > -1; i--) {
            if (i == numeros.size()-1)
                System.out.print("[" + numeros.get(i));
            else
                System.out.print(", " + numeros.get(i));
        }
        System.out.println("]");
    }
    
}

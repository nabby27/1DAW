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
public class Ejercicio02 {
    
    private static int totalElementos = 12;
    
    public static void main(String[] args) {
        
        int origen[] = {10, 25, 26, 40, 37, 45, 90, 76, 78, 81, 58, 32};
        ArrayList<Integer> destino = new ArrayList<Integer>();
        int i = 0;
        
        for (int numero : origen) {
            if (numero % 2 == 0 && numero > 25) {
                destino.add(i, numero);
                i++;
            }
        }
        System.out.print("origen: ");
        for (int j = 0; j < origen.length; j++) {
            if (j == 0)
                System.out.print("[" + origen[j] + ", ");
            else if (j == origen.length-1)
                System.out.print(origen[j] + "]");
            else
                System.out.print(origen[j] + ", ");
        }
        System.out.println("");
        System.out.print("destino: " + destino);
        System.out.println("");
    }
    
}

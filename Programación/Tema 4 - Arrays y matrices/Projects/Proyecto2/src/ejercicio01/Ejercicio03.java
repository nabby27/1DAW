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
public class Ejercicio03 {
    
    public static void main(String[] args) {
        ArrayList<Integer> notas = new ArrayList<Integer>();
        ArrayList<Integer> notasBajoMedia = new ArrayList<Integer>();
        Scanner sc = new Scanner(System.in);
        int nota = 0;
        int media = 0;
        
        for (int i = 0; i < 10; i++) {
            do {
                System.out.println("Dime la nota " + (i+1));
                nota = sc.nextInt();
                if (nota < 0 || nota > 10)
                    System.out.println("La nota no es valida, tiene que estar entre 0 y 10");
            } while(nota < 0 || nota > 10);
            notas.add(nota);
        }
        
        for (Integer n : notas) {
            media += n;
        }
        media /= 10;
        for (Integer n : notas) {
            if (n < media)
                notasBajoMedia.add(n);
        }
        
        System.out.println("Las notas son: " + notas);
        System.out.println("La media es: " + media);
        System.out.println("Las notas por debajo de la media son: " + notasBajoMedia);
    }
    
}

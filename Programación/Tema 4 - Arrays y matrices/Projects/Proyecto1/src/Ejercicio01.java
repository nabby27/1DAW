
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
    
    private static final int totalElementos = 15;
    
    public static void main(String[] args) {
    
        Scanner sc = new Scanner(System.in);
        int[] notas = new int[totalElementos];
        int suma = 0;
        
        for (int nota : notas) {
            System.out.println("Dime un número");
            nota = sc.nextInt();
        }
        
        System.out.println();
        
        for (int i = 0; i < notas.length; i++) {
            if (i % 2 == 0)
                suma += notas[i];
        }
        
        System.out.print("La suma de los apres es :" + suma);
    
    }
    
}


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
    
    private static final int totalElementos = 10;
    static Scanner sc = new Scanner(System.in);

    
    public static void main(String[] args) {
    
        int[] notas = new int[totalElementos];
        int menor = 0;
        
        asignarDatosTeclado(notas);
        
        for (int i = 0; i < notas.length; i++) {
            if (i == 0) {
                menor = i;
            }
            else if (notas[i] < notas[menor]) {
                menor = i;
            }
        }
        
        System.out.println("El menor es " + notas[menor] + " que esta en el indice " + menor);
    }
    
    public static void asignarDatosTeclado(int[] notas) {
        for (int i = 0; i < notas.length; i++) {
            System.out.println("Dime un número");
            notas[i] = sc.nextInt();
        }
        System.out.println();
    }
    
}

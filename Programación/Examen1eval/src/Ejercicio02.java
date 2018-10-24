
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejercicio02 {
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número entre 1 y 10 (inclusives)");
            num = teclado.nextInt();
            if (num < 1 || num > 10)
                System.out.println("El número no está en el rango");
        } while (num < 1 || num > 10);
        
        for (int i = 1; i <= num; i++) {
            if (i % 2 == 0) {
                for (int j = 0; j < num; j++) {
                    System.out.print("*");
                }
                System.out.println("");
            } else {
                for (int j = 0; j < num; j++) {
                    System.out.print(i);
                }
                System.out.println("");
            }
        }
        
    }
    
}

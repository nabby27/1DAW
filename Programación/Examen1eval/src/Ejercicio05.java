
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
public class Ejercicio05 {
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.println("¿Que tabla quieres calcular?(del 1 al 9 inclusives)");
            num = teclado.nextInt();
            if (num < 1 || num > 9)
                System.out.println("El número no esta en el rango");
        } while (num < 1 || num > 9);
        
        for (int i= 0; i <= 15; i++) {
            System.out.println(num + " x " + i + " = " + (num*i));
        }
    }
    
}

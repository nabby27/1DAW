
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
public class Ejercicio01 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int cantidad = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número positivo: ");
            num = teclado.nextInt();
            if (num < 0)
                System.out.println("el número tiene que ser positivo");
        } while (num < 0);
            
        for (int x = 1; x <= num; x++) {
            if (x % 3 == 0) {
                System.out.println(x);
                cantidad++;
            }
        }
        
        System.out.println("la cantidad de números divisibles por 3 son: " + cantidad);
        
    }
}

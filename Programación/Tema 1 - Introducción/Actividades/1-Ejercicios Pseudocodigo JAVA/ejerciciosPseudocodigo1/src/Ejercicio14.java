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
public class Ejercicio14 {
    
    public static void main(String[] args) {
        System.out.println("¿MÚLTIPLO DE 3?");
        
        boolean multiplo = false;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 5; x++) {
            System.out.print("Dime un número (" + (x+1) + "/5): ");
            int num = teclado.nextInt();
            if (num % 3 == 0)
                multiplo = true;
        }
        
        if (multiplo)
            System.out.println("Hay algún número multiplo de 3");
        else
            System.out.println("No hay ningún múltiplo de 3");
    }
    
}

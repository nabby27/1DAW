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
        System.out.println("CUENTA POSITIVOS");
        
        int cantidad = 0;
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 10; x++) {
            System.out.print("Dime un número (" + (x+1) + "/10): ");
            num = teclado.nextInt();
            if (num > 0)
                cantidad++;
        }
        
        System.out.println("Hay " + cantidad + " numeros positivos");
    }
    
}

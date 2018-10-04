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

    public static void main(String[] args) {
        System.out.println("¿Cuantos ceros?");
        
        int cantidad = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 15; x++) {
            System.out.print("Dime un número: ");
            int num = teclado.nextInt();
            if (num == 0)
                cantidad++;
        }
        
        System.out.print("La sequencia de números tiene " + cantidad + " ceros");
    }
    
}

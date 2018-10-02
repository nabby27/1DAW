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
public class ejercicio04a {
    
    public static void main(String[] args) {
        System.out.println("¿LA SUMA DE DOS ES IGUAL AL OTRO?");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime X: ");
        float x = teclado.nextFloat();
        System.out.print("Dime Y: ");
        float y = teclado.nextFloat();
        System.out.print("Dime Z: ");
        float z = teclado.nextFloat();
        
        if ((x + y == z) || (z + x == y) || (y + z == x))
            System.out.println("Sí");
        else
            System.out.println("No");
    }
    
}

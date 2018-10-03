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
public class ejercicio06 {

    public static void main(String[] args) {
        System.out.println("LA SUMA DE DOS ES IGUAL AL TERCERO");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número X: ");
        int x = teclado.nextInt();
        System.out.print("Dime el número Y: ");
        int y = teclado.nextInt();
        System.out.print("Dime el número Z: ");
        int z = teclado.nextInt();
        
        if ((x + y == z) || (z + x == y) || (y + z == x))
            System.out.println("Sí");
        else
            System.out.println("No");
    }

}

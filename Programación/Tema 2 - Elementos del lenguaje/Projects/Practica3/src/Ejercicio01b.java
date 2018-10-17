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
public class Ejercicio01b {
    
    public static void main(String[] args) {
        
        float x = 0;
        float y = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el valor de x: ");
        x = teclado.nextFloat();
        System.out.print("Dime el valor de y: ");
        y = teclado.nextFloat();
        
        if (x > y)
            System.out.println("x: " + x +" es mayor que y: " + y );
        else if (y > x)
            System.out.println("y: " + y +" es mayor que x: " + x );
        else
            System.out.println("x: " + x +" e y: " + y + " son iguales");
    }
    
}

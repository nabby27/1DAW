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
public class ejercicio04 {
    
    public static void main(String[] args) {
        System.out.println("Z será el mayor");
        
        float z;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime X: ");
        float x = teclado.nextFloat();
        System.out.print("Dime Y: ");
        float y = teclado.nextFloat();
        
        if (x > y)
            z = x; 
        else
            z = y;
        
        System.out.println("Z es: " + z);
    }
    
}

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
public class ejercicio05 {
    
    public static void main(String[] args) {
        System.out.println("X ¿IGUAL, MENOR O MAYOR?");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime X: ");
        float x = teclado.nextFloat();
        System.out.print("Dime Y: ");
        float y = teclado.nextFloat();
        
        if (x < y)
            System.out.println("X es menor");
        else if (y < x)
            System.out.println("X es mayor");
        else
            System.out.println("X e Y son iguales");
    }
    
}

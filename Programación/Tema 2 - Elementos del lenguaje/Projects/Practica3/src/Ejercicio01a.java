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
public class Ejercicio01a {
    
    public static void main(String[] args) {
        
        float x = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el valor de x: ");
        x = teclado.nextFloat();
        
        System.out.println("1/(x^2-1) = " + (1/((x*x)-1)));
    }
    
}

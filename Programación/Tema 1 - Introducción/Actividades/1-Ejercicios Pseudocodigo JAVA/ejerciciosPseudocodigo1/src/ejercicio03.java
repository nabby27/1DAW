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
public class ejercicio03 {
   
    public static void main(String[] args) {
        System.out.println("¿X es mayor?");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime X: ");
        float x = teclado.nextFloat();
        System.out.print("Dime Z: ");
        float z = teclado.nextFloat();
        
        if (x > z) {
            System.out.println("Verdadero");
        } else {
            System.out.println("Falso");
        }
    }
    
}

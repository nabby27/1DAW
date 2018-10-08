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
public class Ejercicio25 {
        
    public static void main(String[] args) {
        System.out.println("FACTORIAL");
        
        int resultado = 1;
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número menor de 10: ");
            num = teclado.nextInt();
            if ((num < 0) || (num > 10))
                System.out.println("El numero introducido no es correcto, tiene que estar entre 0 y 10");
        } while ((num < 0) || (num > 10));
        for (int x = 1; x <= num; x++) {
            resultado *= x;
        }
        
        System.out.println("El factorial de " + num + " es: " + resultado);
    }
    
}

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
public class Ejercicio27 {
            
    public static void main(String[] args) {
        System.out.println("PRIMO MAYOR DE 0");
        
        boolean primo = true;
        int num = 0;
        int x = 2;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número mayor de 0: ");
            num = teclado.nextInt();
            if (num < 0)
                System.out.println("El número tiene que ser mayor de 0");
        } while (num < 0);
        while ((x < num) && (primo)) {
            if (num % x == 0)
                primo = false;
            x++;
        }
        
        if (primo)
            System.out.println("El número " + num + " es primo");
        else
            System.out.println("El número " + num + " no es primo");
    }
    
}

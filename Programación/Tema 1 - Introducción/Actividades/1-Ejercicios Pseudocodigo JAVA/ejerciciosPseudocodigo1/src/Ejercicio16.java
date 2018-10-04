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
public class Ejercicio16 {
    
    public static void main(String[] args) {
        System.out.println("¿ES PRIMO?");
        
        boolean primo = true;
        int num = 0;
        int x = 2;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número: ");
        num = teclado.nextInt();
        while (x < num && primo) {
            if ((num % x == 0))
                primo = false;
            x++;
        }
        
        if (primo)
            System.out.println("Es primo");
        else
            System.out.println("No es primo");
    }
    
}

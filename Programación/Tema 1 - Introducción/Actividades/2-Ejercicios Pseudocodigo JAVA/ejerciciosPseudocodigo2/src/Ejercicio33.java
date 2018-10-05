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
public class Ejercicio33 {
    
    public static void main(String[] args) {
        System.out.println("TRIANGULO DE FLOYD");
        
        int num = 0;
        int contador = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número:");
            num = teclado.nextInt();
            if (num < 0 || num > 20) 
                System.out.println("El número no esta entre 0 y 20");
        } while(num < 0 || num > 20);
        
        for (int x = 1; x <= num; x++) {
            for (int y = 1; y <= x; y++) {
                contador++;
                if (y == x) {
                    System.out.print(contador + " ");
                    System.out.println();
                }
                else
                    System.out.print(contador + " ");
            }
        }
    }
    
}

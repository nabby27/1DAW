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
public class Ejercicio19 {
    
    public static void main(String[] args) {
        System.out.println("CUENTA CIFRAS");
        
        boolean acierto = false;
        int cifras = 0;
        int num = 0;
        int x = 10;
        Scanner teclado = new Scanner(System.in);
        do {
            System.out.print("Dime un número: ");
            num = teclado.nextInt();
            if (num < 0)
                System.out.println("El número tiene que ser positivo");
        } while (num < 0);
        
        while (!acierto) {
            if (num < x)
                acierto = true;
            else
                x *= 10;
            cifras++;
        }
        if (num > 0)
            System.out.println("El número " + num + " tiene " + cifras + " cifra/s");
        else
            System.out.println("El número tiene que ser positivo");
    }
    
}

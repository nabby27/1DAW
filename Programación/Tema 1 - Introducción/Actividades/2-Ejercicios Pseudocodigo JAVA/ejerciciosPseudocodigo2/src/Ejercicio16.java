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
        System.out.println("ADIVINA");
        
        boolean acierto = false;
        int x = 0;
        int num = 0;
        int numAdivinar = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número a adivinar: ");
        numAdivinar = teclado.nextInt();
        for (int i = 0; i < 500; ++i) System.out.println();
        System.out.println("ADIVINA");
        while (x < 5 && !acierto) {
            System.out.print("(" + (x+1) + "/5) Adivina el número: ");
            num = teclado.nextInt();
            if (numAdivinar == num)
                acierto = true;
            else if (numAdivinar > num)
                System.out.println("Te has quedado corto");
            else
                System.out.println("Te has pasado");
            x++;
        }
        if (acierto)
            System.out.println("Correcto!!! lo hiciste en " + x + " intento/s");
        else 
            System.out.println("Ooohhh! Se te acabaron los intentos");
    }
    
}

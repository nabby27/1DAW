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
public class Ejercicio31 {
            
    public static void main(String[] args) {
        System.out.println("CIFRAS");
        
        int cantidadCifras = 0;
        int num = 0;
        int numAbs = 0;
        int x = 10;
        boolean terminado = false;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número: ");
        num = teclado.nextInt();
 
        numAbs = Math.abs(num);
        
        while (!terminado) {
            if (numAbs < x) 
                terminado = true;
            else 
                x*= 10;
            cantidadCifras++;
        }

        System.out.println("El número " + num + " tiene " + cantidadCifras + " cifra/s");
    }
    
}

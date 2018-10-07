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
public class Ejercicio14 {
    
    static final int numVueltas = 10;
    
    public static void main(String[] args) {
        System.out.println("10 DISTINTOS DE 0");
        
        int mayor = 0;
        int num = 0;
        boolean negativo = false;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < numVueltas; x++) {
            System.out.print("Dime un número:");
            num = teclado.nextInt();
            if (num != 0) {
                if ((num > mayor) || (x == 0))
                    mayor = num;
                if (num < 0)
                    negativo = true;
            }
        }
        
        System.out.println("El número más alto es el: " + mayor);
        if (negativo)
            System.out.println("Hay algún número negativo");
        else
            System.out.println("No hay ningún número negativo");
    }
    
}

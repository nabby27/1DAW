
import java.util.Random;
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejercicio03b {
    
    public static void main(String[] args) {
        
        int dado1;
        int dado2;
        int cantidad = 0;
        
        for (int x = 0; x < 100; x++) {
            dado1 = new Random().nextInt(6) + 1; 
            dado2 = new Random().nextInt(6) + 1;
            if (dado1 + dado2 == 10)
                cantidad++;
        }
        
        System.out.println("La cantidad de veces que suman 10 es: " + cantidad);
        
    }
}

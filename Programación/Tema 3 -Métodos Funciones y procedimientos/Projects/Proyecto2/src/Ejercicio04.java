
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio04 {
    
    public static void main(String[] args) {
        Random rnd = new Random();
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int mayor = 0;
        
        for (int i = 0; i < 20; i++) {
            num1 = rnd.nextInt(1001);
            num2 = rnd.nextInt(1001);
            num3 = rnd.nextInt(1001);
            mayor  = mayor(num1, num2, num3);
            System.out.println((i+1) + " - El número más grande de " + num1 + ", " + num2 + " y " + num3 + " es: " + mayor);
        }
    }
    
    private static int mayor(int a, int b) {
        return a >= b? a : b;
    }
    private static int mayor(int a, int b, int c) {
        return mayor(mayor(a, b), c);
    }
    
}

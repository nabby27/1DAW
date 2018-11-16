
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
public class Ejercicio01 {
    
    public static void main(String[] args) {
        int n1 = 0;
        int n2 = 0;
        Random rnd = new Random();
        
        for (int i = 0; i < 20; i++) {
            n1 = rnd.nextInt(1001);
            n2 = rnd.nextInt(1001);
            System.out.println((i+1) + " - Suma de " + n1 + " + " + n2 + " = " + suma(n1, n2));
        }
    }
    
    private static int suma(int a, int b) {
        return a + b;
    }
}

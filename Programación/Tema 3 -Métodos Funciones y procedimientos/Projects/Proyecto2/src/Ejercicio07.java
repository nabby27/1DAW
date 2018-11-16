
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
public class Ejercicio07 {
        
    public static void main(String[] args) {
        
        Random rnd = new Random();
        
        for (char c = 'a'; c <= 'z'; c++) {
            int num1 = rnd.nextInt(31);
            int num2 = rnd.nextInt(31);
            escribir(c, num1, num2);
        }
    }
    
    private static void escribir(char a, int b, int c) {
        for (int j = 0; j < c; j++) {
            for (int i = 1; i < b; i++) {
                System.out.print(a);
            }
            System.out.println(a);
        }
    }
    
}

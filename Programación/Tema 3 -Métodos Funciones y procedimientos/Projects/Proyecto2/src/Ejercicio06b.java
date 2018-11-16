
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
public class Ejercicio06b {
        
    public static void main(String[] args) {
        
        Random rnd = new Random();
        
        for (char c = 'a'; c <= 'z'; c++) {
            int num = rnd.nextInt(31);
            System.out.print(num + " - ");
            escribir(c, num);
            System.out.println("");
        }
    }
    
    private static void escribir(char a, int b) {
        for (int i = 0; i < b; i++) {
            System.out.print(a);
        }
    }
    
}

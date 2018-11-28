
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
public class Ejercicio01 {
    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        int[] elementos = new int[15];
        int suma = 0;
        
        for (int i = 0; i < elementos.length; i++) {
            System.out.println("Dime el número " + (i+1));
            elementos[i] = sc.nextInt();
        }
        
    }
    
}

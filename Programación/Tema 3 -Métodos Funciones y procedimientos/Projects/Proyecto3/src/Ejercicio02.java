
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
public class Ejercicio02 {
        
    public static void main(String[] args) {
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Cuantos números?");
        num = sc.nextInt();
        
        escribirAsteriscos(num);
    }
    
    private static void escribirAsteriscos(int num) {
        for (int i = num; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                System.out.print("*");
            }
            System.out.println("");
        }
    }
    
}

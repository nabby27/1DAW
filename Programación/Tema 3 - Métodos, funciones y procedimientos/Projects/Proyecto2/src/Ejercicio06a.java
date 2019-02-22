
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
public class Ejercicio06a {
    
    public static void main(String[] args) {
        
        char text = 'a';
        int num = 0;
        Scanner keyboard = new Scanner(System.in);
        
        System.out.println("Dime que caracter quieres repetir");
        text = keyboard.next().charAt(0);
        
        System.out.println("Cuantas veces quieres repetirlo?");
        num = keyboard.nextInt();
        
        escribir(text, num);
    }
    
    private static void escribir(char a, int b) {
        for (int i = 0; i < b; i++) {
            System.out.println((i+1) + " - " + a);
        }
    }
    
}

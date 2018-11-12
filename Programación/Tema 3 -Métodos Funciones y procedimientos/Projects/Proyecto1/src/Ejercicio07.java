
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
public class Ejercicio07 {
    
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        String oracion = "";
        
        System.out.println("Dime tu nombre y apellidos:");
        oracion = keyboard.nextLine();
        
        initialWord(oracion);
    }
    
    public static void initialWord(String oracion) {
        String[] words = oracion.split(" ");
        String[] initialWords = new String[words.length];
        
        for (int i = 0; i < words.length; i++) {
            initialWords[i] = words[i].substring(0,1);
        }
        
        for (int i = 0; i < words.length; i++) {
            System.out.print(initialWords[i] + ". ");
        }
        
        System.out.println("");
    }
    
}

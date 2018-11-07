
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
public class Ejercicio06 {
    
    public static void main(String[] args) {
        String oracion = "";
        Scanner keyboard = new Scanner(System.in);
        
        System.out.println("Dime una frase:");
        oracion = keyboard.nextLine();
        reverse(oracion);
    }
    
    public static void reverse(String oracion) {
        String[] ora = oracion.split("");
        String[] reverse = new String[ora.length];
        
        for (int i = 0; i < ora.length; i++) {
            reverse[ora.length-i] = ora[i];
        }
        
        for (int i = 0; i < ora.length; i++) {
            System.out.print(reverse[i]);
        }
    }
    
}

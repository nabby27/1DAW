
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio08 {
    
    public static void main(String[] args) {
        String oracion = "Hola soy Iván";        
        System.out.println(oracion);
        removeLastWord(oracion);
    }
    
    public static void removeLastWord(String oracion) {
        String[] words = oracion.split(" ");
        String[] newWords = new String[words.length];
        
        for (int i = 0; i < words.length; i++) {
            newWords[i] = words[i].substring(0,words[i].length() - 1);
        }
        
        for (int i = 0; i < words.length; i++) {
            if (i == 0)
                System.out.print(newWords[i]);
            else 
                System.out.print(" " + newWords[i]);
        }
        
        System.out.println("");
    }
    
}

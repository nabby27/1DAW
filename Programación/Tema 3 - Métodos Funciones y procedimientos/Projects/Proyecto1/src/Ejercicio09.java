
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio09 {
    
    public static void main(String[] args) {
        String oracion = "Hola soy Iván";        
        System.out.println(oracion);
        countCharOfWord(oracion);
    }
    
    public static void countCharOfWord(String oracion) {
        String[] words = oracion.split(" ");
        int[] newWords = new int[words.length];
        
        for (int i = 0; i < words.length; i++) {
            newWords[i] = words[i].length();
        }
        
        for (int i = 0; i < words.length; i++) {
            if (i == 0)
                System.out.print(newWords[i]);
            else 
                System.out.print(", " + newWords[i]);
        }
        
        System.out.println("");
    }
    
}

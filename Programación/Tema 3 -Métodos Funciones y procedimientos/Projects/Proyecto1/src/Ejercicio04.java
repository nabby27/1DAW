/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio04 {
    
    public static void main(String[] args) {
        String oracion = "Hola aa hola, adios hola de nuevo";
        countVocals(oracion);
    }
    
    public static void countVocals(String oracion) {
        int count = 0;
        String[] letras = oracion.split("");
        for (int i = 0; i < letras.length; i++) {
            if (letras[i].equalsIgnoreCase("a") || 
                letras[i].equalsIgnoreCase("e") ||
                letras[i].equalsIgnoreCase("i") ||
                letras[i].equalsIgnoreCase("o") ||
                letras[i].equalsIgnoreCase("u"))
                    count++;
        }
        System.out.println("La frase tiene " + count + " vocales");
    }
    
}

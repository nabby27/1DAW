/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio03 {
    
    public static void main(String[] args) {
        String oracion = "Hola aa hola, adios hola de nuevo";
        countWords(oracion);
    }
    
    public static void countWords(String oracion) {
        String[] palabras = oracion.split(" ");
        System.out.println("La frase tiene " + palabras.length + " palabras");
    }
    
}

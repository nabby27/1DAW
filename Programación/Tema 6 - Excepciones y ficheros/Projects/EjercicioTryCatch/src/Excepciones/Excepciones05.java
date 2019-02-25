/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Excepciones;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Excepciones05 {
    
    public static void main(String[] args) {
        mostrarCadenasArray(new String[] {"Hola", null, "ivan"});
    }
    
    public static void mostrarCadenasArray(String[] cadenas) {
        for (String cadena : cadenas) {
            if (cadena != null)
                System.out.println(cadena.substring(0, 1));
        }
    }
    
}

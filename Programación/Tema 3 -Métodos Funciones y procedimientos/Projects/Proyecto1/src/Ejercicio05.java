/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio05 {
    
    public static void main(String[] args) {
        String oracion = "Hola aa hola, adios hola de nuevo";
        removeBlankSpace(oracion);
    }
    
    public static void removeBlankSpace(String oracion) {
        oracion = oracion.replace(" ", "");
        System.out.println(oracion);
    }
    
}

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
        String oracion = "Hola aa hola, adios hola de nuevo";
        int posicion = 8;
        charInPosition(oracion, posicion);
    }
    
    public static void charInPosition(String oracion, int posicion) {
        if (posicion <= oracion.length()-1 && posicion > 0) {
            String caracter = oracion.substring(posicion, posicion+1);
            System.out.println("La letra en la posicion '" + posicion + "' es: " + caracter);
        } else {
            System.out.println("La posición no es correcta tiene que estar entre 0 y la cantidad de letras de la oración");
        }
    }
    
}

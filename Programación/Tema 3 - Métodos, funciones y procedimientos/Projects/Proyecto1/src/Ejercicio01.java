/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio01 {
    
    public static void main(String[] args) {
        String oracion = "Hola aa hola, adios hola de nuevo";
        String palabra = "hola";
        countRepeat(oracion, palabra);
    }
    
    public static void countRepeat(String oracion, String palabra) {
        int cont = 0;
        oracion = oracion.replace(",", "");
        oracion = oracion.replace("-", "");
        oracion = oracion.replace("\"", "");
        oracion = oracion.replace("'", "");
        oracion = oracion.replace(";", "");
        oracion = oracion.replace(".", "");
        String[] palabrasOracion = oracion.split(" ");
        for (int i = 0; i < palabrasOracion.length; i++) {
            if (palabrasOracion[i].equalsIgnoreCase(palabra))
                cont++;
        }
        System.out.println("La cantidad de veces que se repita la palabra '" + palabra + "' es: " + cont);
    }
    
}

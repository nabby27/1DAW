
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
public class Ejercicio02 {
    
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        String oracion = "";
        int posicion = -1;
        do {
            System.out.println("Introduce una oracion:");
            oracion = keyboard.nextLine();
        } while(oracion.isEmpty());
        do {
            System.out.println("Que posición quieres buscar?");
            posicion = keyboard.nextInt();
        } while(posicion < 0 || posicion > oracion.length());
        
        charInPosition(oracion, posicion);
    }
    
    public static void charInPosition(String oracion, int posicion) {
        if (posicion <= oracion.length()-1 && posicion > 0) {
            String caracter = oracion.substring(posicion, posicion+1);
            System.out.println("La letra en la posicion '" + posicion + "' es: '" + caracter + "'");
        } else {
            System.out.println("La posición no es correcta tiene que estar entre 0 y la cantidad de letras de la oración");
        }
    }
    
}

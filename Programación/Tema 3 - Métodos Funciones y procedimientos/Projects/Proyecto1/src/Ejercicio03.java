
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
public class Ejercicio03 {
    
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        String oracion = "";
        do {
            System.out.println("Introduce una frase:");
            oracion = keyboard.nextLine();
        } while (oracion.isEmpty());
        countWords(oracion);
    }
    
    public static void countWords(String oracion) {
        String[] palabras = oracion.split(" ");
        System.out.println("La frase tiene " + palabras.length + " palabras");
    }
    
}

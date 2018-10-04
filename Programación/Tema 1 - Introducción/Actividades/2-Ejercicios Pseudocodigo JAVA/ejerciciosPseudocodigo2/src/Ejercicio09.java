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
public class Ejercicio09 {
    
    public static void main(String[] args) {
        System.out.println("SUMA Y MULTIPLICA");
        
        int suma = 0;
        int multiplicacion = 1;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 20; x <= 40; x += 2) {
            suma += x;
            multiplicacion *= x;
        }
        
        System.out.println("La suma de los pares entre 20 y 40 (inclusives) es: " + suma);
        System.out.println("La multiplicacion de los pares entre 20 y 40 (inclusives) es: " + multiplicacion);
    }

}


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
        
        int suma = 0;
        
        for (int x = 1; x <= 10; x++) {
            System.out.println("El cuadrado de " + x + " es: " + (x*x));
            suma += (x*x);
        }
        
        System.out.println("La suma de los cuadrados de los 10 primeros números naturales es: " + suma);
    }
    
}

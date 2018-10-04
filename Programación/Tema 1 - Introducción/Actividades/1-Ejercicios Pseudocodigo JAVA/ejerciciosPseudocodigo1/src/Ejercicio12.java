/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio12 {
    
    public static void main(String[] args) {
        System.out.println("SUMA 10 PARES");
        
        int resultado = 0;
        
        for (int x = 0; x <= 20; x += 2) {
            resultado += x;
        }
        
        System.out.println("La suma de los 10 primeros pares es: " + resultado);
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class ejercicio13 {
    
    public static void main(String[] args) {
        System.out.println("SUMA 10 IMPARES");
        
        int resultado = 0;
        
        for (int x = 1; x <= 21; x += 2) {
            resultado += x;
        }
        
        System.out.println("La suma de los 10 primeros impares es: " + resultado);
    }
    
}

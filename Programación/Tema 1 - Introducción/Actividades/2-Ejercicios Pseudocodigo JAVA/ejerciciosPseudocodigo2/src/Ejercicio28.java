
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio28 {
            
    public static void main(String[] args) {
        System.out.println("TABLAS DE MULTIPLICAR");
                
        for (int x = 1; x <= 10; x++) {
            System.out.println("TABLA DEL " + x);
            for (int y = 0; y <= 10; y++) {
                System.out.println(x + " x " + y + ": " + (x * y));
            }
        }
    }
    
}

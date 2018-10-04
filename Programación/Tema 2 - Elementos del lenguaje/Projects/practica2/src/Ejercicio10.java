/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio10 {
    
    public static void main(String[] args) {
        int result;
        int a = 2;
        int b = 4;

        result = -a + 5 % b - a * a;
        System.out.println("Apartado a)");
        System.out.println("El resultado es " + result);
        
        result = 5 + 3 % 7 * b * a - b % a;
        System.out.println("\nApartado b)");
        System.out.println("El resultado es " + result);    
        
        result = (a+1) * (b + 1) - b / a;
        System.out.println("\nApartado c)");
        System.out.println("El resultado es " + result);
   }
    
}

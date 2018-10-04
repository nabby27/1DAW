
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
        System.out.println("200 NÚMEROS");
        
        int sumaPares = 0;
        int sumaImpares = 0;
        
        for (int x = 0; x <= 200; x++) {
            if (x % 2 == 0)
                sumaPares += x;
            else
                sumaImpares += x;
        }
        
        System.out.println("La suma de los numeros pares es: " + sumaPares);
        System.out.println("La suma de los numeros impares es: " + sumaImpares);
    }
    
}

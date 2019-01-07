
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
        Scanner sc = new Scanner(System.in);
        int[] numeros = new int[10];
        boolean negativo = false;
        int mayor = 0;
        
        for (int i = 0; i < numeros.length; i++) {
            do {
                System.out.println("Dime un número distinto de 0");
                numeros[i] = sc.nextInt();
                if (numeros[i] == 0)
                    System.out.println("El número no puede ser 0");
            } while(numeros[i] == 0);
        }
        
        for (int i = 0; i < numeros.length; i++) {
            if (numeros[i] < 0) {
                negativo = true;
            }
            if (numeros[i] > mayor || i == 0) {
                mayor = numeros[i];
            }
        }
        
        System.out.println("El mayor número es: " + mayor);
        if (negativo){
            System.out.println("Hay algún número negativo");
        } else {
            System.out.println("NO hay ninguno número negativo");
        }
    }
    
}

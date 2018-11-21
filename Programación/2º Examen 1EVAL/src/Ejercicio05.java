
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
public class Ejercicio05 {
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número para calcular su factorial:");
            num = sc.nextInt();
            if (num < 0 || num > 10)
                System.out.println("El número tiene que estar entre 0 y 10");
        } while(num < 0 || num > 10);
        
        System.out.println("El factorial de " + num + " es: " + factorial(num));
    }
    
    /**
     * Método que calcula el factorial del número introducido
     * @param num número del cual calcular el factorial
     * @return el factorial del número
     */
    private static long factorial(int num) {
        long resultado = 1;
        for (int i = 1; i <= num; i++) {
            resultado *= i;
        }
        return resultado;
    }
    
}

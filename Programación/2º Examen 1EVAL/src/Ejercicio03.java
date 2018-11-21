
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
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número para hacer el triangulo de floyd:");
            num = sc.nextInt();
            if (num < 1)
                System.out.println("El número tiene que ser mayor de 0");
        } while(num < 1);
        
        floyfModificado(num);
    }
    
    /**
     * Métofo que muestra un triangulo de floyd modificado
     * @param num ´altura del triangulo
     */
    private static void floyfModificado(int num) {
        for (int x = 1; x <= num; x++) {
            int suma = 0;
            for (int y = 1; y <= x; y++) {
                System.out.print(y);
                suma += y;
            }
            System.out.print(" .Su suma es: " + suma);
            System.out.println();
        }
    }
    
}

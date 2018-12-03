
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
public class Ejercicio02 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int suma = 0;
        int contador = 0;
        int maroy100 = 0;
        boolean negativo = false;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número (0 para salir):");
            num = sc.nextInt();
            
            suma += num;
            if (num != 0)
                contador++;
            if (num > 100)
                maroy100++;
            if (num < 0)
                negativo = true;                    
        } while (num != 0);
        
        System.out.println("Has introducido " + contador + " número/s");
        System.out.println("La suma de los números introducidos es: " + suma);
        System.out.println("Hay " + maroy100 + " números mayores de 100");
        if (negativo)
            System.out.println("Has introducido como mínimo un negativo");
        else
            System.out.println("No has introducido ningún negativo");
    }
    
   
    
}

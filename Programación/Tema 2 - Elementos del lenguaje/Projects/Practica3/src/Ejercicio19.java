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
public class Ejercicio19 {
    
    public static void main(String[] args) {
        
        int repetir = 0;
        int cantidadPares = 0;
        int cantidadImpares = 0;
        int num = 0;
        float porcPares = 0;
        float porcImpares = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime cuantas veces repetir la secuencia: ");
        repetir = teclado.nextInt();
        
        for (int x = 0; x < repetir; x++) {
            num = ((int) (Math.random() * 10));
            if (num % 2 == 0)
                cantidadPares++;
            else
                cantidadImpares++;
        }
        
        porcPares = ((float) cantidadPares/repetir) * 100;
        porcImpares = ((float) cantidadImpares/repetir) * 100;
        
        System.out.println("Han salido " + cantidadPares + " números pares");
        System.out.println("El porcentage de pares es: " + porcPares + "%");
        
        System.out.println("Han salido " + cantidadImpares + " números impares");
        System.out.println("El porcentage de impares es: " + porcImpares + "%");
    }
    
}

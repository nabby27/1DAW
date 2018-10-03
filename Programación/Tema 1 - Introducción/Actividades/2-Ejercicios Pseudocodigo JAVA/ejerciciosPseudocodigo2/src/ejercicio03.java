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
public class ejercicio03 {

    public static void main(String[] args) {
        System.out.println("10 NÚMEROS");
        
        int sumaPares = 0;
        int cantidadPares = 0;
        float sumaImpares = 0;
        float cantidadImpares = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 10; x++) {
            System.out.print("Dime un número: ");
            int num = teclado.nextInt();
            if (num % 2 == 0) {
                sumaPares += num;
                cantidadPares++;
            } else {
                sumaImpares += num;
                cantidadImpares++;
            }
        }
        
        System.out.println("La suma de los numeros pares es: " + sumaPares);
        System.out.println("Hay " + cantidadPares + " numero/s par/es");
        System.out.println("La media de los impares es: " + (sumaImpares / cantidadImpares));
    }
    
}

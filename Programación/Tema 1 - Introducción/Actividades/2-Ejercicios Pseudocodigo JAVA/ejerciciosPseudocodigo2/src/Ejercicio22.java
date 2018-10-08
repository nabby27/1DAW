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
public class Ejercicio22 {
    
    public static void main(String[] args) {
        System.out.println("MULTIPLICA CON SUMAS");
        
        int a = 0;
        int n = 0;
        int resultado = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime a: ");
        a = teclado.nextInt();
        System.out.print("Dime n: ");
        n = teclado.nextInt();
        for (int x = 0; x < n; x++) {
            resultado += a;
        }
        
        System.out.println("El resultado de " + a + " x " + n + " con sumas, es: " + resultado);
    }
    
}

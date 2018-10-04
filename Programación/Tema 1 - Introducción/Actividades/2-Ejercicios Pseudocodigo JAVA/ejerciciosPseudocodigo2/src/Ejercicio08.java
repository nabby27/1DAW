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
public class Ejercicio08 {
    
    public static void main(String[] args) {
        System.out.println("SUMA K ENTEROS");
        
        int resultado = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número de K: ");
        int num = teclado.nextInt();
        
        for (int x = 0; x <= num; x++) {
            resultado += x;
        }
        
        System.out.println("La suma es: " + resultado);
    }

}

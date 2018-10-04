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
public class Ejercicio09 {
    
    public static void main(String[] args) {
        System.out.println("SUMA NÚMEROS");
        
        float resultado = 0;
        float num = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuantos números quieres sumar?");
        int cantidad = teclado.nextInt();
        for (int x = 0; x < cantidad; x++) {
            System.out.print("Dime el número (" + (x+1) + "/" + cantidad + "): ");
            num = teclado.nextFloat();
            resultado += num;
        }
        
        System.out.println("El resultado es: " + resultado);
    }
    
}

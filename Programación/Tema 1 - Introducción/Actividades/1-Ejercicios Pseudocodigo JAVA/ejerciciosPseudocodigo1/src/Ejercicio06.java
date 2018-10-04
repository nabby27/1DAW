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
public class Ejercicio06 {
    
    public static void main(String[] args) {
        System.out.println("CALCULAR LA POTENCIA");
        
        float resultado = 1;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime la base: ");
        float base = teclado.nextFloat();
        System.out.print("Dime el exponente: ");
        float exponente = teclado.nextFloat();
        
        for (int x = 0; x < exponente; x++) {
            resultado *= base;
        }
        
        System.out.println("El resultado de " + base + " elevado " + exponente + " es: " + resultado);
    }
    
}

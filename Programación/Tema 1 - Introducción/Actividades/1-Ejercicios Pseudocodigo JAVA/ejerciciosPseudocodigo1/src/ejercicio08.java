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
public class ejercicio08 {
    
    public static void main(String[] args) {
        System.out.println("MULTIPLICA 5 NÚMEROS");
        
        float resultado = 1;
        float num = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 5; x++) {
            System.out.print("Dime el número " + (x+1) + ": ");
            num = teclado.nextFloat();
            resultado *= num;
        }
        
        System.out.println("El resultado es: " + resultado);
    }
    
}

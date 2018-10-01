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
public class ejercicio02b {
   
    public static void main(String[] args) {
        System.out.println("CALCULAR PRECIO FINAL");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el precio:");
        float precio = teclado.nextFloat();
        System.out.print("Dime el descuento:");
        float descuento = teclado.nextFloat();
        
        System.out.println("El precio total es: " + (precio - ((descuento * precio) / 100)));
    }
    
}

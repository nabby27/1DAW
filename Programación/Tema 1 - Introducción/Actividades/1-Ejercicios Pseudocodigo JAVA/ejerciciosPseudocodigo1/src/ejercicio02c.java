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
public class ejercicio02c {
   
    public static void main(String[] args) {
        System.out.println("CALCULAR DESCUENTO");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el precio inicial: ");
        float precioInicial = teclado.nextFloat();
        System.out.print("Dime el precio final: ");
        float precioFinal = teclado.nextFloat();
        
        System.out.println("El precio total es: " + ((1 - (precioFinal / precioInicial)) * 100));
    }
    
}

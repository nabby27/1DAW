
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejercicio06 {
    
    public static void main(String[] args) {
         
        int x = 0, mayor100 = 0;
        float num = 0;
        boolean negativo = false;
        Scanner teclado = new Scanner(System.in);
        
        while (x < 11){
            System.out.print("Dime un número:");
            num = teclado.nextFloat();
            if (num > 100)
                mayor100++;
            else if (num < 0)
                negativo = true;
            x++;
        }
        
        System.out.println("Has introducido " + (x-1) + "número/s");
        System.out.println("Hay " + mayor100 + " número/s mayor/es de 100");
        if (negativo)
            System.out.println("Hay al menos un número negativo");
        else 
            System.out.println("No hay ningún número negativo");
    }
    
}

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
public class Ejercicio29 {
            
    public static void main(String[] args) {
        System.out.println("NÚMEROS SIN 0");
        
        int cantidadNegativos = 0;
        int cantidadPositivos = 0;
        float suma = 0;
        float num = 0;
        boolean mayor100 = false;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número (0-Salir)");
            num = teclado.nextInt();
            if (num < 0)
                cantidadNegativos++;
            else if (num > 0) {
                suma += num;
                cantidadPositivos++;
                if (num > 100)
                    mayor100 = true;
            }
        } while (num != 0);
        
        System.out.println("Hay " + cantidadNegativos + " número/s negativ/s");
        if (mayor100)
            System.out.println("Hay algún número mayor de 100");
        else
            System.out.println("No hay ningún número mayor de 100");
        System.out.println("La media de los números positivos es: " + (suma / cantidadPositivos));
    }
    
}
